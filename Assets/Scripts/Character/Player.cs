using Components;
using UnityEngine;

namespace Character
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        private FireComponent _fireComponent;

        private Vector2 _moveStep;

        public void Move(float moveDirection)
        {
            _moveStep.x = moveDirection * Time.fixedDeltaTime;
            _moveComponent.Move(_moveStep);
        }

        public void Shoot()
        {
            _fireComponent.Shoot(Vector2.up);
        }
    }
}