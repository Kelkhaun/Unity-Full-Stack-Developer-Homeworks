using Atomic.Contexts;

namespace Game.Scripts.Context
{
    public interface IGameContext : IContext
    {

    }

    public sealed class GameContext : SingletonSceneContext<GameContext>, IGameContext
    {
        
    }
}