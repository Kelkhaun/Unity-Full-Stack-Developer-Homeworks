using System;
using System.Collections.Generic;
using Game.Scripts.Views;
using Modules.Planets;
using Zenject;

namespace Game.Scripts.Presenters
{
    public sealed class PlanetGroupPresenter : IInitializable, IDisposable
    {
        private readonly PlanetView[] _view;
        private readonly IPlanet[] _planets;

        private List<PlanetPresenter> _planetPresenters = new();
        private PlanetPresenterFactory _planetPresenterFactory;

        public PlanetGroupPresenter(PlanetView[] view, IPlanet[] planets,
            PlanetPresenterFactory planetPresenterFactory)
        {
            _planetPresenterFactory = planetPresenterFactory;
            _view = view;
            _planets = planets;
        }

        public void Initialize()
        {
            for (int i = 0; i < _view.Length; i++)
            {
                var presenter = _planetPresenterFactory.Create(_view[i], _planets[i]);
                _planetPresenters.Add(presenter);
            }

            _planetPresenters.ForEach(presenter => presenter.Enable());
        }

        public void Dispose()
        {
            _planetPresenters.ForEach(presenter => presenter.Disable());
        }
    }
}