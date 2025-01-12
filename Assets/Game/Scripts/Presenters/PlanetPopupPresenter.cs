using System;
using Game.Scripts.Views;
using Modules.Money;
using Modules.Planets;

namespace Game.Scripts.Presenters
{
    public class PlanetPopupPresenter : IPlanetPopupPresenter
    {
        public event Action OnPlanetUpgrade;
        public event Action OnMoneyChanged;
        
        public event Action<int> OnPopulationChanged
        {
            add => _planet.OnPopulationChanged += value;
            remove => _planet.OnPopulationChanged -= value;
        }

        private IPlanet _planet;
        private IMoneyStorage _moneyStorage;

        public string PlanetName => _planet.Name;
        public string PlanetPopulation => "Population: " + _planet.Population;
        public string PlanetLevel => "Level: " + _planet.Level + "/" + _planet.MaxLevel;
        public string PlanetIncome => "Income: " + _planet.MinuteIncome + " / sec";
        public string PlanetPrice => _planet.Price != Planet.UNDEFINED_PRICE
            ? _planet.Price.ToString()
            : "Max Level";

        public bool IsButtonActive =>
            _moneyStorage.IsEnough(_planet.Price) && _planet.MaxLevel > _planet.Level;

        public PlanetPopupPresenter(IMoneyStorage moneyStorage)
        {
            _moneyStorage = moneyStorage;
        }

        public void SetPlanet(IPlanet planet)
        {
            _planet = planet;
        }

        public void Enable()
        {
          _moneyStorage.OnMoneyChanged += UpdateState;
        }

        public void Disable()
        {
            _moneyStorage.OnMoneyChanged -= UpdateState;
        }

        private void UpdateState(int newvalue, int prevvalue)
        {
            OnMoneyChanged?.Invoke();
        }

        public void OnUpgradeButtonClick()
        {
            _planet.Upgrade();
            OnPlanetUpgrade?.Invoke();
        }
    }
}