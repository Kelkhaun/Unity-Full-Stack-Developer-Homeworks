using System;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class DamageComponent : MonoBehaviour
    {
        public event Action OnAttack;

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