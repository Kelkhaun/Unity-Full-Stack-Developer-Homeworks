using UnityEngine;
using Zenject;

namespace Game.Scripts.Gameplay.PlanetPopup
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