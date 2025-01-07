using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.SaveSystem.SaveLoader
{
    public sealed class LocalSaveLoader : ISaveLoader
    {
        private readonly string _filePath;
        private const string _fileExtension = ".txt";

        public LocalSaveLoader(string fileName)
        {
            _filePath = $"{Application.streamingAssetsPath}/{fileName}_";
        }

        public async UniTask<bool> Save(string json, int version)
        {
            await File.WriteAllTextAsync(_filePath + version + _fileExtension, json);
            return true;
        }

        public async UniTask<(bool, string)> Load(int version)
        {
            if (File.Exists(_filePath + version + _fileExtension))
            {
                string json = await File.ReadAllTextAsync(_filePath + version + _fileExtension);
                return (true, json);
            }

            return (false, null);
        }
    }
}
