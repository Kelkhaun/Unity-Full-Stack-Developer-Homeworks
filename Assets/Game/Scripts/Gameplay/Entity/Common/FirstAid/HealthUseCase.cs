using System;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.FirstAid
{
    public sealed class HealthUseCase
    {
        public static bool AddHealth(IEntity character, int health)
        {
            if (character == null)
                return false;

            var maxHealth = character.GetMaxHealth();
            var currentHealth = character.GetCurrentHealth();

            currentHealth.Value = Math.Max(currentHealth.Value + health, maxHealth.Value);

            return true;
        }
    }
}