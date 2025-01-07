using Modules.Ecryption;

namespace Game.Scripts.SaveSystem.Repostiory
{
    public sealed class StringEncryptor
    {
        private readonly string _aesPassword;
        private readonly byte[] _aesSalt;

        public StringEncryptor(string aesPassword, byte[] aesSalt)
        {
            _aesPassword = aesPassword;
            _aesSalt = aesSalt;
        }

        public string Encrypt(string text)
        {
            return AesEncryptor.Encrypt(text, _aesPassword, _aesSalt);
        }

        public string Decrypt(string text)
        {
            return AesEncryptor.Decrypt(text, _aesPassword, _aesSalt);
        }
    }
}