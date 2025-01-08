using System;
using Cysharp.Threading.Tasks;
using Game.Scripts.Save;
using Game.Scripts.SaveSystem;
using Game.Scripts.SaveSystem.SaveLoader;
using ModestTree;
using UnityEngine;

namespace Game.Gameplay
{
    public sealed class ControlsPresenter : IControlsPresenter
    {
        private GameSaveLoader _saveLoader;

        public ControlsPresenter(GameSaveLoader saveLoader)
        {
            _saveLoader = saveLoader;
        }

        public void Save(Action<bool, int> callback)
        {
            SaveAsync(callback);
        }

        public void Load(string versionText, Action<bool, int> callback)
        {
            LoadAsync(versionText, callback);
        }

        private async UniTaskVoid SaveAsync(Action<bool, int> callback)
        {
            var saveResult = await _saveLoader.Save();
            callback?.Invoke(saveResult.Success, saveResult.SaveVersion);
        }
        
        private async UniTaskVoid LoadAsync(string versionText, Action<bool, int> callback)
        {
            int loadedVersion;
            
            if (versionText.IsEmpty())
                loadedVersion = -1;
            else
                loadedVersion = int.Parse(versionText);
                            
            var loadResult = await _saveLoader.Load(loadedVersion);
            callback?.Invoke(loadResult.Success, loadResult.SaveVersion);
        }
    }
}