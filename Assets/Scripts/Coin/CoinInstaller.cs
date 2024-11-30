using UnityEngine;
using Zenject;

namespace Coin
{
    public sealed class CoinInstaller : MonoInstaller
    {
        [SerializeField]
        private Modules.Coin _coinPrefab;

        public override void InstallBindings()
        {
            Container.BindMemoryPool<Modules.Coin, CoinPool>()
                .WithInitialSize(10)
                .ExpandByOneAtATime()
                .FromComponentInNewPrefab(_coinPrefab)
                .UnderTransformGroup("Coins")
                .AsSingle();

            Container.BindInterfacesAndSelfTo<CoinManager>()
                .AsSingle();
        }
    }
}