using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Health
{
    public sealed class HealthInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private ReactiveInt _currentHealth;

        [SerializeField]
        private ReactiveInt _maxHealth;

        override public void Install(IEntity entity)
        {
            entity.AddCurrentHealth(_currentHealth);
            entity.AddMaxHealth(_maxHealth);
        }
    }
}