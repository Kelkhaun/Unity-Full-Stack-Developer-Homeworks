using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Game.Scripts.SaveSystem.SaveLoader;
using Newtonsoft.Json;
using UnityEngine;

namespace Game.Scripts.SaveSystem.Repostiory
{
    public sealed class GameRepository : IGameRepository
    {
        private const string SAVE_VERSION = "saveVersion";
        private readonly StringEncryptor _stringEncryptor;
        private readonly ISaveLoader[] _saveLoaders;

        public GameRepository(ISaveLoader[] saveLoaders, StringEncryptor stringEncryptor)
        {
            _saveLoaders = saveLoaders;
            _stringEncryptor = stringEncryptor;
        }

        public async UniTask<OperationResult> SetState(Dictionary<string, string> gameState)
        {
            int saveVersion = PlayerPrefs.GetInt(SAVE_VERSION, 0);
            saveVersion++;
            PlayerPrefs.SetInt(SAVE_VERSION, saveVersion);

            string json = JsonConvert.SerializeObject(gameState);
            string encryptedJson = _stringEncryptor.Encrypt(json);

            foreach (var saveLoader in _saveLoaders)
                await saveLoader.Save(encryptedJson, saveVersion);

            return new OperationResult { SaveVersion = saveVersion, Success = true, SaveData = gameState };
        }

        public async UniTask<OperationResult> GetState(int loadVersion)
        {
            if (loadVersion > PlayerPrefs.GetInt(SAVE_VERSION, 0)
                || loadVersion < 0)
                return new OperationResult { Success = false, SaveVersion = loadVersion, SaveData = null };

            Dictionary<string, string>[] _loadedStates = new Dictionary<string, string>[_saveLoaders.Length];

            for (int i = 0; i < _saveLoaders.Length; i++)
            {
                _loadedStates[i] = null;
                var (success, json) = await _saveLoaders[i].Load(loadVersion);

                if (success)
                {
                    string decriptedJson = _stringEncryptor.Decrypt(json);

                    if (!string.IsNullOrWhiteSpace(decriptedJson))
                        _loadedStates[i] = JsonConvert.DeserializeObject<Dictionary<string, string>>(decriptedJson);
                }
            }

            foreach (var state in _loadedStates)
                if (state != null)
                    return new OperationResult { Success = true, SaveVersion = loadVersion, SaveData = state };

            return new OperationResult { Success = false, SaveVersion = loadVersion, SaveData = null };
        }
    }
}