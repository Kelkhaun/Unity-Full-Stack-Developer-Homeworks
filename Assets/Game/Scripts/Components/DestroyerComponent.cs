using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components
{
    public sealed class DestroyerComponent : MonoBehaviour
    {
        public UnityEvent OnDestroy;

        [SerializeField]
        private ColliderProxyComponent _colliderProxy;

        private void OnEnable()
        {
            _colliderProxy.OnColliderTouched += DestroyGameObject;
        }

        private void OnDisable()
        {
            _colliderProxy.OnColliderTouched -= DestroyGameObject;
        }

        private void DestroyGameObject(GameObject collidedObject)
        {
            if (collidedObject.TryGetComponent(out HealthComponent healthComponent))
            {
                OnDestroy?.Invoke();
                healthComponent.Die();
            }
        }
    }
}