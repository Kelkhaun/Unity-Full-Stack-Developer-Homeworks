using Modules;
using SnakeGame;
using UnityEngine;
using Zenject;

namespace UI
{
    public sealed class UIInstaller : MonoInstaller
    {
        [SerializeField] private GameUI _gameUI;

        public override void InstallBindings()
        {
            Container.Bind<IGameUI>()
                .FromInstance(_gameUI)
                .AsSingle();

            Container.BindInterfacesAndSelfTo<DifficiltyViewObserver>()
                .AsSingle()
                .NonLazy();

            Container.BindInterfacesAndSelfTo<ScoreViewObserver>()
                .AsSingle()
                .NonLazy();
        }
    }
}