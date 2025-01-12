using Game.Scripts.Views;
using Modules.Planets;

namespace Game.Scripts.Presenters
{
    public class PlanetPopupShower
    {
        private PlanetPopupPresenter _planetPopupPresenter;
        private PlanetPopupView _planetPopupView;

        public PlanetPopupShower(PlanetPopupView planetPopupView, PlanetPopupPresenter planetPopupPresenter)
        {
            _planetPopupPresenter = planetPopupPresenter;
            _planetPopupView = planetPopupView;  
        }

        public void Show(IPlanet planet)
        {
            _planetPopupPresenter.SetPlanet(planet);
            _planetPopupView.gameObject.SetActive(true);
        }                                          
    }
}