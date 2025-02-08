using System;
using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class ColliderProxyComponent : MonoBehaviour
    {
        public event Action<GameObject> OnColliderTouched;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            OnColliderTouched?.Invoke(collider.gameObject);
        }
    }
}