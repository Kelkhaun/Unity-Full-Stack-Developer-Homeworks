using Cysharp.Threading.Tasks;

namespace Game.Scripts.SaveSystem.SaveLoader
{
    public interface ISaveLoader
    {
        UniTask<bool> Save(string json, int version);
        UniTask<(bool, string)> Load(int version);
    }
}