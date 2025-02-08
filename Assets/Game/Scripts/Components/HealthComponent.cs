using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components
{
    public sealed class HealthComponent : MonoBehaviour
    {
        public UnityEvent OnHealthChanged;
        public UnityEvent OnHealthLost;

        [SerializeField]
        private int _maxHealth;

        private int _currentHealth;

        public bool IsAlive => _currentHealth >= 0;

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
                return;

            _currentHealth -= damage;
            OnHealthChanged?.Invoke();

            if (_currentHealth <= 0)
                OnHealthLost?.Invoke();
        }

        public void Die()
        {
            _currentHealth = 0;
            OnHealthChanged?.Invoke();
            OnHealthLost?.Invoke();
        }
    }
}