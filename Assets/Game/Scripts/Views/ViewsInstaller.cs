using Modules.UI;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Views
{
    public sealed class ViewsInstaller : MonoInstaller
    {
        [SerializeField]
        private MoneyView _moneyView;

        [SerializeField]
        private PlanetView[] _planetViews;

        [SerializeField]
        private ParticleAnimator _particleAnimator;

        public override void InstallBindings()
        {
            Container.Bind<MoneyView>()
                .FromInstance(_moneyView)
                .AsSingle();

            Container.Bind<ParticleAnimator>()
                .FromInstance(_particleAnimator)
                .AsSingle();

            foreach (var planetView in _planetViews)
            {
                Container.BindInterfacesAndSelfTo<PlanetView>()
                    .FromInstance(planetView)
                    .AsCached()
                    .NonLazy();
            }
        }
    }
}