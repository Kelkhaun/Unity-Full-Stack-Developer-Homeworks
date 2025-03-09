using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Death
{
    public sealed class DeathBehaviour : IEntityInit, IEntityDispose
    {
        private ReactiveInt _currentHealth;
        private IEvent _deathEvent;

        public void Init(in IEntity entity)
        {
            _currentHealth = entity.GetCurrentHealth();
            _deathEvent = entity.GetDeathEvent();

            _currentHealth.OnValueChanged += OnHealthChanged;
        }

        public void Dispose(in IEntity entity)
        {
            _currentHealth.OnValueChanged -= OnHealthChanged;
        }

        private void OnHealthChanged(int health)
        {
            if(health <= 0)
                _deathEvent?.Invoke();
        }
    }
}