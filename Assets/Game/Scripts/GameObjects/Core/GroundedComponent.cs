using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class GroundedComponent : MonoBehaviour
    {
        [SerializeField]
        private LayerMask _groundLayer;

        [SerializeField]
        private Vector2 _checkboxSize;

        private bool _isGrounded;

        public bool IsGrounded => _isGrounded;

        private void Update()
        {
            _isGrounded = Physics2D.OverlapBox(transform.position, _checkboxSize, 0, _groundLayer);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position, _checkboxSize);
        }
    }
}