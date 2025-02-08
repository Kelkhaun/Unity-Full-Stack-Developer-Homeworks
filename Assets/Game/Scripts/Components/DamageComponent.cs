using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components
{
    public sealed class DamageComponent : MonoBehaviour
    {
        public UnityEvent OnAttack;

        [SerializeField]
        private HealthComponent _health;

        [SerializeField]
        private int _damage;

        public void Attack(GameObject gameObject)
        {
            if (gameObject.TryGetComponent(out HealthComponent healthComponent))
            {
                healthComponent.TakeDamage(_damage);
                OnAttack?.Invoke();
            }
        }
    }
}