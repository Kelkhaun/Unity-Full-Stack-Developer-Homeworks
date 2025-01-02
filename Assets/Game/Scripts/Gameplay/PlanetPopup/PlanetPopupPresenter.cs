using System;
using Modules.Planets;

namespace Game.Scripts.Gameplay.PlanetPopup
{
    public class PlanetPopupPresenter : IPlanetPopupPresenter
    {
        public event Action OnPlanetUpgrade;

        public event Action<int> OnPopulationChanged
        {
            add => _planet.OnPopulationChanged += value;
            remove => _planet.OnPopulationChanged -= value;
        }

        private IPlanet _planet;

        private IMoneyAdapter _moneyAdapter;

        public string PlanetName => _planet.Name;
        public string PlanetPopulation => "Population: " + _planet.Population;
        public string PlanetLevel => "Level: " + _planet.Level + "/" + _planet.MaxLevel;
        public string PlanetIncome => "Income: " + _planet.MinuteIncome + " / sec";
        public string PlanetPrice => _planet.Price != Planet.UNDEFINED_PRICE
            ? _planet.Price.ToString()
            : "Max Level";

        public bool IsButtonActive =>
            _moneyAdapter.IsEnough(_planet.Price) && _planet.MaxLevel > _planet.Level;

        public PlanetPopupPresenter(IPlanet planet, IMoneyAdapter moneyAdapter)
        {
            _planet = planet;
            _moneyAdapter = moneyAdapter;
        }

        public void OnUpgradeButtonClick()
        {
            _planet.Upgrade();
            OnPlanetUpgrade?.Invoke();
        }
    }
}