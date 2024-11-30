using SnakeGame;
using UnityEngine;
using Zenject;

namespace Bounds
{
    public sealed class WorldInstaller : MonoInstaller
    {
        [SerializeField] private WorldBounds _worldBounds;

        public override void InstallBindings()
        {
            Container.Bind<IWorldBounds>()
                .FromInstance(_worldBounds)
                .AsSingle();

            Container.BindInterfacesAndSelfTo<SnakeInBoundChecker>()
                .AsSingle();
        }
    }
}
