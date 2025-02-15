using System;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class TriggerComponent : MonoBehaviour
    {
        public event Action<GameObject> OnEnter;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            OnEnter?.Invoke(collider.gameObject);
        }
    }

}