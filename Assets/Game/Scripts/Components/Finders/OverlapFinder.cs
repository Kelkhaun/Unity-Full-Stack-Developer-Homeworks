using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Components.Finders
{
    public sealed class OverlapFinder : FindTargetComponent
    {
        [SerializeField]
        private Vector2 _checkboxSize;

        [SerializeField]
        private LayerMask _interactableLayer;

        [SerializeField]
        private Transform _overlapPoint;

        private void Update()
        {
            Find();
        }

        private void Find()
        {
            _targets.Clear();

            var colliders = Physics2D.OverlapBoxAll(
                _overlapPoint.transform.position,
                _checkboxSize,
                0,
                _interactableLayer);

            foreach (var collider in colliders)
            {
                _targets.Add(collider.gameObject);
            }
        }

        override public List<GameObject> GetTargets()
        {
            return _targets;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(_overlapPoint.transform.position, _checkboxSize);
        }
    }
}