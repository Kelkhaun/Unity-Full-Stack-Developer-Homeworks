using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Modules.Encryption.Scripts;
using Newtonsoft.Json;
using UnityEngine;

namespace Modules.SaveSystem.Repository
{
    public sealed class GameRepository : IGameRepository
    {
        private const string SAVE_VERSION = "saveVersion";
        private readonly StringEncryptor _stringEncryptor;
        private readonly IStorage[] _orderStorages;

        public GameRepository(IStorage[] orderStorages, StringEncryptor stringEncryptor)
        {
            _orderStorages = orderStorages;
            _stringEncryptor = stringEncryptor;
        }

        public async UniTask<OperationResult> SetState(Dictionary<string, string> gameState)
        {
            int saveVersion = PlayerPrefs.GetInt(SAVE_VERSION, 0);
            saveVersion++;
            PlayerPrefs.SetInt(SAVE_VERSION, saveVersion);

            string json = JsonConvert.SerializeObject(gameState);
            string encryptedJson = _stringEncryptor.Encrypt(json);

            var tasks = new List<UniTask>();

            foreach (var saveLoader in _orderStorages)
                tasks.Add( saveLoader.Save(encryptedJson, saveVersion));

            await UniTask.WhenAll(tasks);

            return new OperationResult { SaveVersion = saveVersion, Success = true, SaveData = gameState };
        }

        public async UniTask<OperationResult> GetState(int loadVersion)
        {
            if (loadVersion > PlayerPrefs.GetInt(SAVE_VERSION, 0) || loadVersion < 0)
            {
                return new OperationResult { Success = false, SaveVersion = loadVersion, SaveData = null };
            }

            var tasks = new List<UniTask<(bool success, string json)>>();
            foreach (var storage in _orderStorages)
            {
                tasks.Add(storage.Load(loadVersion));
            }

            var results = await UniTask.WhenAll(tasks);

            foreach (var (success, json) in results)
            {
                if (success)
                {
                    string decryptedJson = _stringEncryptor.Decrypt(json);

                    if (!string.IsNullOrWhiteSpace(decryptedJson))
                    {
                        var state = JsonConvert.DeserializeObject<Dictionary<string, string>>(decryptedJson);
                        if (state != null)
                        {
                            return new OperationResult { Success = true, SaveVersion = loadVersion, SaveData = state };
                        }
                    }
                }
            }

            return new OperationResult { Success = false, SaveVersion = loadVersion, SaveData = null };
        }
    }
}