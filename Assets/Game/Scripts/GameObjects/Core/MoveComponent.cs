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

        [SerializeField]
        private float _maxSpeed = 5;

        [SerializeField]
        private bool _isNeedClampVelocity = true;

        public void Move(Vector2 direction)
        {
            _rigidbody.velocity += direction * (_speed * Time.deltaTime);

            if (_isNeedClampVelocity)
                _rigidbody.velocity = Vector2.ClampMagnitude(_rigidbody.velocity, _maxSpeed);

            OnMove?.Invoke(_rigidbody.velocity);
        }
    }
}