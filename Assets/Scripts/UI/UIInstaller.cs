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

            Container.BindInterfacesAndSelfTo<DifficiltyViewAdapter>()
                .AsSingle()
                .NonLazy();

            Container.BindInterfacesAndSelfTo<ScoreViewAdapter>()
                .AsSingle()
                .NonLazy();
        }
    }
}