using System;
using Cysharp.Threading.Tasks;
using ModestTree;
using Modules.SaveSystem.SaveLoader;

namespace Game.Scripts.UI
{
    public sealed class ControlsPresenter : IControlsPresenter
    {
        private readonly GameSaveLoader _saveLoader;

        public ControlsPresenter(GameSaveLoader saveLoader)
        {
            _saveLoader = saveLoader;
        }

        public void Save(Action<bool, int> callback)
        {
            SaveAsync(callback).Forget();
        }

        public void Load(string versionText, Action<bool, int> callback)
        {
            LoadAsync(versionText, callback).Forget();
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