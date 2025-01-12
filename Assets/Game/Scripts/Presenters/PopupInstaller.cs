using Game.Scripts.Views;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Presenters
{
    public sealed class PopupInstaller : MonoInstaller
    {
        [SerializeField] private PlanetPopupView _planetPopupView;

        public override void InstallBindings()
        {
            Container.Bind<PlanetPopupView>()
                .FromInstance(_planetPopupView)
                .AsSingle();
            
            Container.Bind<PlanetPopupShower>()
                .AsSingle();
        }
    }
}