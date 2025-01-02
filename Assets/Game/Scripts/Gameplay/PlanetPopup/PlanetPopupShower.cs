using Modules.Planets;

namespace Game.Scripts.Gameplay.PlanetPopup
{
    public class PlanetPopupShower
    {
        private PlanetPopupView _planetPopupView;
        private IMoneyAdapter _moneyAdapter;

        public PlanetPopupShower(PlanetPopupView planetPopupView, IMoneyAdapter moneyAdapter )
        {
            _planetPopupView = planetPopupView;
            _moneyAdapter = moneyAdapter;
        }

        public void Show(IPlanet planet)
        {
            var presenter = new PlanetPopupPresenter(planet, _moneyAdapter);
            _planetPopupView.Show(presenter);
        }
    }
}