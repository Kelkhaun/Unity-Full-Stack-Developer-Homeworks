using Game.Scripts.SaveSystem.SaveLoader;
using Modules.Encryption.Scripts;
using UnityEngine;
using Zenject;

namespace Game.Scripts.SaveSystem.Repostiory
{
    [CreateAssetMenu(
        fileName = "RepositoryInstaller",
        menuName = "Zenject/App/New RepositoryInstaller"
    )]
    public sealed class RepositoryInstaller : ScriptableObjectInstaller
    {
        [SerializeField]
        private string _fileName = "GameState";

        [SerializeField]
        private string _aesPassword = "123";

        [SerializeField]
        private byte[] _aesSalt = {0x52, 0x41, 0x16, 0x79, 0x86, 0x64, 0x97, 0x22};

        [SerializeField]
        private string _url = "http://127.0.0.1:8888";
    
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameRepository>()
                .AsSingle();

            Container.BindInterfacesAndSelfTo<RemoteSaveLoader>()
                .AsSingle()
                .WithArguments(_url);
        
            Container.BindInterfacesAndSelfTo<LocalSaveLoader>()
                .AsSingle()
                .WithArguments(_fileName);
        
            Container.Bind<StringEncryptor>()
                .AsSingle()
                .WithArguments(_aesPassword, _aesSalt);
        }
    }
}
