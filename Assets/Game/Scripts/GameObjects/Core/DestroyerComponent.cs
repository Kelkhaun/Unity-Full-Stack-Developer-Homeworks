using System;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class DestroyerComponent : MonoBehaviour
    {
        public event Action OnDestroy;

        public void DestroyGameObject(GameObject collidedObject)
        {
            if (collidedObject.TryGetComponent(out HealthComponent healthComponent))
            {
                OnDestroy?.Invoke();
                healthComponent.Die();
            }
        }
    }
}