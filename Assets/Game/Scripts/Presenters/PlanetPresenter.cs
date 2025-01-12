using Game.Scripts.Views;
using Modules.Planets;
using UnityEngine;

namespace Game.Scripts.Presenters
{
    public sealed class PlanetPresenter
    {
        private readonly PlanetView _view;
        private readonly IPlanet _planet;
        private readonly PlanetPopupShower _planetPopupShower;
        private readonly MoneyViewPresenter _moneyViewPresenter;

        public PlanetPresenter(PlanetView view, IPlanet planet, PlanetPopupShower planetPopupShower,
            MoneyViewPresenter moneyViewPresenter)
        {
            _moneyViewPresenter = moneyViewPresenter;
            _view = view;
            _planet = planet;
            _planetPopupShower = planetPopupShower;
        }

        public void Enable()
        {
            _view.Lock(_planet.GetIcon(false), _planet.Price.ToString());

            _view.OnClicked += OnClicked;
            _view.OnHolded += OnHolded;
            _planet.OnIncomeTimeChanged += OnIncomeTimeChanged;
            _planet.OnIncomeReady += OnIncomeReady;
            _planet.OnGathered += OnGathered;
            _planet.OnUnlocked += OnUnlocked;
        }

        public void Disable()
        {
            _view.OnClicked -= OnClicked;
            _view.OnHolded -= OnHolded;
            _planet.OnIncomeTimeChanged -= OnIncomeTimeChanged;
            _planet.OnIncomeReady -= OnIncomeReady;
            _planet.OnGathered -= OnGathered;
            _planet.OnUnlocked-= OnUnlocked;
        }

        private void OnUnlocked()
        {
            _view.Unlock(_planet.GetIcon(true));
        }

        private void OnClicked()
        {
            if (!_planet.IsUnlocked)
            {
                if (_planet.CanUnlockOrUpgrade)
                {
                    _planet.Unlock();
                }
            }
            else
            {
                if (_planet.IsIncomeReady)
                    _planet.GatherIncome();
            }
        }

        private void OnHolded()
        {
            if (_planet.IsUnlocked)
                _planetPopupShower.Show(_planet);
        }

        private void OnGathered(int _)
        {
            _moneyViewPresenter.AnimateIncome(_view.GetCoinPosition());
        }

        private void OnIncomeReady(bool isIncomeReady)
        {
            _view.SetIncomeReadyStatus(isIncomeReady);
        }

        private void OnIncomeTimeChanged(float remainingTime)
        {
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);

            _view.SetTime($"{minutes}m:{seconds}s", _planet.IncomeProgress);
        }
    }
}