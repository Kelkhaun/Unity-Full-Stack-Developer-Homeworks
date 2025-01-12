using UnityEngine;
using Zenject;

namespace Modules.SaveSystem.Repository
{
    [CreateAssetMenu(
        fileName = "SaveLoaderInstaller",
        menuName = "Zenject/App/New SaveLoaderInstaller"
    )]
    public sealed class StorageInstaller : ScriptableObjectInstaller
    {
        [SerializeField]
        private string _fileName = "GameState";

        [SerializeField]
        private string _url = "http://127.0.0.1:8888";
    
        public override void InstallBindings()
        {
            Container.Bind<IStorage[]>()
                .FromMethod((() =>
                {
                    return new IStorage[]
                    {
                        new RemoteStorage(_url),
                        new LocalStorage(_fileName)
                    };
                }))
                .AsSingle();
        }
    }
}