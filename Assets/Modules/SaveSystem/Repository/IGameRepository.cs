using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Modules.SaveSystem.Repository
{
    public interface IGameRepository
    {
        UniTask<OperationResult> GetState(int loadVersion);
        UniTask<OperationResult> SetState(Dictionary<string, string> gameState);
    }
}
