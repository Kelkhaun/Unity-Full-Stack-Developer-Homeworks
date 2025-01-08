using UnityEngine;
using Zenject;

namespace Game.Scripts.Encryptor
{
    [CreateAssetMenu(
        fileName = "EncryptorInstaller",
        menuName = "Zenject/App/New EncryptorInstaller"
    )]
    public sealed class EncryptorInstaller : ScriptableObjectInstaller
    {
        [SerializeField]
        private string _aesPassword = "123";

        [SerializeField]
        private byte[] _aesSalt = {0x52, 0x41, 0x16, 0x79, 0x86, 0x64, 0x97, 0x22};
    
        public override void InstallBindings()
        {
            Container.Bind<StringEncryptor>()
                .AsSingle()
                .WithArguments(_aesPassword, _aesSalt);
        }
    }
}