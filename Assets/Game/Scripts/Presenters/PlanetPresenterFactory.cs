using Game.Scripts.Views;
using Modules.Planets;
using Zenject;

namespace Game.Scripts.Presenters
{
    public sealed class PlanetPresenterFactory : PlaceholderFactory<PlanetView, IPlanet, PlanetPresenter>
    {
    }
}