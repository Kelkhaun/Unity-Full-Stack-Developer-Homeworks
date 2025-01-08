using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Game.Scripts.SaveSystem.Repostiory;
using Game.Scripts.SaveSystem.Serializer;

namespace Game.Scripts.SaveSystem.SaveLoader
{
    public sealed class GameSaveLoader
    {
        private readonly IGameRepository _repository;
        private readonly IEnumerable<IGameSerializer> _serializers;

        public GameSaveLoader(IGameRepository repository, IEnumerable<IGameSerializer> serializers)
        {
            _repository = repository;
            _serializers = serializers;
        }

        public async UniTask<OperationResult> Save()
        {
            var gameState = new Dictionary<string, string>();
            foreach (IGameSerializer serializer in _serializers)
                serializer.Serialize(gameState);

            return await _repository.SetState(gameState);
        }

        public async UniTask<OperationResult> Load(int loadVersion)
        {
            var operationResult = await _repository.GetState(loadVersion);

            if (operationResult.SaveData != null)
                foreach (IGameSerializer serializer in _serializers)
                    serializer.Deserialize(operationResult.SaveData);

            return operationResult;
        }
    }
}