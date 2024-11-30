using Difficulty;
using Score;
using Zenject;

namespace Infrasctrusture
{
    public sealed class GameCycleInstaller : MonoInstaller
    {
        private int _maxLevels = 9;

        public override void InstallBindings()
        {
            Container.Bind<GameManager>()
                .AsSingle();

            Container.BindInterfacesTo<GameStateObserver>()
                .AsCached()
                .NonLazy();

            Container.BindInterfacesAndSelfTo<Modules.Difficulty>()
                .AsSingle()
                .WithArguments(_maxLevels);

            Container.BindInterfacesAndSelfTo<DifficultyChanger>()
                .AsSingle();

            Container.Bind<ScoreCounter>()
                .AsSingle();
        }
    }
}