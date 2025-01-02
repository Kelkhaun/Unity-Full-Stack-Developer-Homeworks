using System;
using System.Collections.Generic;
using Game.Scripts.Gameplay.PlanetPopup;
using Game.Scripts.Views;
using Modules.Planets;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Presenters
{
    public sealed class PlanetGroupPresenter : IInitializable, IDisposable
    {
        private PlanetView[] _view;
        private IPlanet[] _planets;
        private IMoneyAdapter _moneyAdapter;

        private List<PlanetPresenter> _planetPresenters = new();
        private PlanetPopupShower _planetPopupShower;

        public event Action<Vector3> OnPlanetGathered;
    
        public PlanetGroupPresenter(PlanetView[] view, IPlanet[] planets ,IMoneyAdapter moneyAdapter, PlanetPopupShower planetPopupShower)
        {
            _view = view;
            _planets = planets;
            _moneyAdapter = moneyAdapter;
            _planetPopupShower = planetPopupShower;
        }

        public void Initialize()
        {
            for (int i = 0; i < _view.Length; i++)
            {
                PlanetPresenter presenter = new(_view[i], _planets[i], _moneyAdapter, _planetPopupShower);
                _planetPresenters.Add(presenter);
            } 
        
            _planetPresenters.ForEach(presenter => presenter.Enable());
            _planetPresenters.ForEach(presenter => presenter.OnPlanetGathered += OnPlanetGathered);
        }

        public void Dispose()
        {
            _planetPresenters.ForEach(presenter => presenter.OnPlanetGathered -= OnPlanetGathered);
            _planetPresenters.ForEach(presenter => presenter.Disable());
        }
    }
}