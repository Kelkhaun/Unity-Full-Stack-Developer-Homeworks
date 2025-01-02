using System;
using Game.Scripts.Gameplay.PlanetPopup;
using Game.Scripts.Views;
using Modules.Planets;
using UnityEngine;

namespace Game.Scripts.Presenters
{
    public sealed class PlanetPresenter
    {
        private PlanetView _view;
        private IPlanet _planet;
        private IMoneyAdapter _moneyAdapter;
        private PlanetPopupShower _planetPopupShower;

        public event Action<Vector3> OnPlanetGathered;
    
        public PlanetPresenter(PlanetView view, IPlanet planet, IMoneyAdapter moneyAdapter,
            PlanetPopupShower planetPopupShower)
        {
            _view = view;
            _planet = planet;
            _moneyAdapter = moneyAdapter;
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
        }

        public void Disable()
        {
            _view.OnClicked -= OnClicked;
            _view.OnHolded -= OnHolded;
            _planet.OnIncomeTimeChanged -= OnIncomeTimeChanged;
            _planet.OnIncomeReady -= OnIncomeReady;
            _planet.OnGathered -= OnGathered;
        }

        private void OnClicked(PlanetView view)
        {
            if (!_planet.IsUnlocked)
            {
                if (_planet.CanUnlock)
                {
                    if (_moneyAdapter.IsEnough(_planet.Price))
                    {
                        _planet.Unlock();
                        view.Unlock(_planet.GetIcon(true));
                    }
                }
            }
            else
            {
                if (_planet.IsIncomeReady)
                    _planet.GatherIncome();
            }
        }

        private void OnHolded(PlanetView view)
        {
            if (_planet.IsUnlocked)
                _planetPopupShower.Show(_planet);
        }

        private void OnGathered(int _)
        {
            OnPlanetGathered?.Invoke(_view.CoinPosition);
        }

        private void OnIncomeReady(bool isIncomeReady)
        {
            _view.SetIncomeReadyStatus(isIncomeReady);
        }

        private void OnIncomeTimeChanged(float remainingTime)
        {
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);

            _view.OnIncomeTimeChanged($"{minutes}m:{seconds}s", _planet.IncomeProgress);
        }
    }
}