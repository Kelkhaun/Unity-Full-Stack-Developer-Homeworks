using System;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class MoveComponent : MonoBehaviour
    {
        public event Action<Vector3> OnMove;

        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private float _speed;

        public void Move(Vector2 direction)
        {
            _rigidbody.velocity += direction * (_speed * Time.deltaTime);
            OnMove?.Invoke(_rigidbody.velocity);
        }

        public void MoveTowards(Transform targetPosition)
        {
            var direction = targetPosition.position - transform.position;

            transform.position = Vector2.MoveTowards(
                transform.position,
                targetPosition.position,
                _speed * Time.deltaTime
            );

            OnMove?.Invoke(direction);
        }
    }
}