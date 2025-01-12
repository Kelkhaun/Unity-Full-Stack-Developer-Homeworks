using System.Collections.Generic;
using Game.Scripts.Views;
using Modules.Planets;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Presenters
{
    [CreateAssetMenu(
        fileName = "PresentersInstallers",
        menuName = "Zenject/New PresentersInstallers"
    )]
    public sealed class PresentersInstallers : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MoneyViewPresenter>()
                .AsSingle()
                .NonLazy();
            
            Container.BindInterfacesAndSelfTo<PlanetGroupPresenter>()
                .AsSingle()
                .NonLazy();

            Container.BindInterfacesAndSelfTo<PlanetPopupPresenter>()
                .AsSingle()
                .NonLazy();

            Container.BindFactory<PlanetView, IPlanet, PlanetPresenter, PlanetPresenterFactory>()
                .AsSingle();
        }
    }
}