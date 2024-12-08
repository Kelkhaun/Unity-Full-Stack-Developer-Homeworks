using Modules;
using Zenject;

namespace Infrasctrusture
{
    public sealed class GameCycleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameManager>()
                .AsSingle();

            Container.BindInterfacesTo<GameStateObserver>()
                .AsCached()
                .NonLazy();

            DifficultyInstaller.Install(Container);

            Container.BindInterfacesAndSelfTo<Score>()
                .AsSingle();
        }
    }
}