using Cysharp.Threading.Tasks;

namespace Modules.SaveSystem.Repository
{
    public interface IStorage
    {
        UniTask<bool> Save(string json, int version);
        UniTask<(bool, string)> Load(int version);
    }
}