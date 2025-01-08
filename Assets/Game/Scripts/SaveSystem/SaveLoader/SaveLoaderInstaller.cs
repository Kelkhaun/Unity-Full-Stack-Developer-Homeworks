using UnityEngine;
using Zenject;

namespace Game.Scripts.SaveSystem.SaveLoader
{
    [CreateAssetMenu(
        fileName = "SaveLoaderInstaller",
        menuName = "Zenject/App/New SaveLoaderInstaller"
    )]
    public sealed class SaveLoaderInstaller : ScriptableObjectInstaller
    {
        [SerializeField]
        private string _fileName = "GameState";

        [SerializeField]
        private string _url = "http://127.0.0.1:8888";
    
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<RemoteSaveLoader>()
                .AsSingle()
                .WithArguments(_url);
        
            Container.BindInterfacesAndSelfTo<LocalSaveLoader>()
                .AsSingle()
                .WithArguments(_fileName);
        }
    }
}