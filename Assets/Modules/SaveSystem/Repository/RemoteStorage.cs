using Cysharp.Threading.Tasks;
using UnityEngine.Networking;

namespace Modules.SaveSystem.Repository
{
    public sealed class RemoteStorage : IStorage
    {
        private readonly string _uri;

        public RemoteStorage(string uri)
        {
            _uri = uri;
        }

        public async UniTask<bool> Save(string json, int version)
        {
            UnityWebRequest request = UnityWebRequest.Put($"{_uri}/save?version={version}", json);
            await request.SendWebRequest();
            return request.result == UnityWebRequest.Result.Success;
        }

        public async UniTask<(bool, string)> Load(int version)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{_uri}/load?version={version}");
            await request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
                return (false, null);

            string json = request.downloadHandler.text;
            return json == null ? (false, null) : (true, json);
        }
    }
}