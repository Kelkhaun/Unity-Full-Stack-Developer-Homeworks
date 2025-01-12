using System;

namespace Game.Scripts.Views
{
    public interface IPlanetPopupPresenter
    {
       public string PlanetName { get; }
       public string PlanetPrice { get; }
       public string PlanetPopulation { get; }
       public string PlanetIncome { get; }
       string PlanetLevel { get; }
       bool IsButtonActive { get; }
       public void OnUpgradeButtonClick();
       event Action OnPlanetUpgrade;
       event Action<int> OnPopulationChanged;

       event Action OnMoneyChanged;

       void Enable();
       void Disable();
    }
}