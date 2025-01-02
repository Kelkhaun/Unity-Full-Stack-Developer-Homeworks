using Game.Scripts.Gameplay.Money;
using Game.Scripts.Gameplay.Planets;
using Modules.Planets;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Gameplay
{
    //Don't modify
    [CreateAssetMenu(
        fileName = "GameplayInstaller",
        menuName = "Zenject/New GameplayInstaller"
    )]
    public sealed class GameplayInstaller : ScriptableObjectInstaller
    {
        [SerializeField]
        private int _initialMoney = 300;

        [SerializeField]
        private PlanetCatalog _catalog;

        public override void InstallBindings()
        {
            MoneyInstaller.Install(this.Container, _initialMoney);
            PlanetInstaller.Install(this.Container, _catalog);
        }
    }
}