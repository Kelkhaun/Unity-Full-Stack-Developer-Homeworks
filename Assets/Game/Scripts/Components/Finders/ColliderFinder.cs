using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components.Finders
{
    public sealed class ColliderFinder : FindTargetComponent
    {
        [SerializeField]
        private LayerMask _filter;

        public UnityEvent OnTargetAdd;
        public UnityEvent OnTargetRemove;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (IsInLayerMask(collider.gameObject))
            {
                _targets.Add(collider.gameObject);
                OnTargetAdd?.Invoke();
            }
        }

        private void OnTriggerExit2D(Collider2D collider)
        {
            if (IsInLayerMask(collider.gameObject))
            {
                _targets.Remove(collider.gameObject);
                OnTargetRemove?.Invoke();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (IsInLayerMask(collision.gameObject))
            {
                _targets.Add(collision.gameObject);
                OnTargetAdd?.Invoke();
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (IsInLayerMask(collision.gameObject))
            {
                _targets.Remove(collision.gameObject);
                OnTargetRemove?.Invoke();
            }
        }

        private bool IsInLayerMask(GameObject gameObject)
        {
            return (_filter.value & (1 << gameObject.layer)) != 0;
        }

        override public List<GameObject> GetTargets()
        {
            return _targets;
        }
    }
}