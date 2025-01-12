using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Modules.SaveSystem.Repository;
using Modules.SaveSystem.SaveLoader.Serializator;

namespace Modules.SaveSystem.SaveLoader
{
    public sealed class GameSaveLoader
    {
        private readonly IGameRepository _repository;
        private readonly IGameSerializer[] _orderSerializers;

        public GameSaveLoader(IGameRepository repository, IGameSerializer[] orderSerializers)
        {
            _repository = repository;
            _orderSerializers = orderSerializers;
        }

        public async UniTask<OperationResult> Save()
        {
            var gameState = new Dictionary<string, string>();

            foreach (IGameSerializer serializer in _orderSerializers)
                serializer.Serialize(gameState);

            return await _repository.SetState(gameState);
        }

        public async UniTask<OperationResult> Load(int loadVersion)
        {
            var operationResult = await _repository.GetState(loadVersion);

            if (operationResult.SaveData != null)
                foreach (IGameSerializer serializer in _orderSerializers)
                    serializer.Deserialize(operationResult.SaveData);

            return operationResult;
        }
    }
}