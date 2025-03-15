using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Rotation
{
    public class RotationBehavior : IEntityInit, IEntityFixedUpdate
    {
        private Rigidbody _rigidbody;
        private ReactiveVector3 _direction;
        private ReactiveFloat _speed;

        public void Init(in IEntity entity)
        {
            _rigidbody = entity.GetRigidbody();
            _direction = entity.GetRotateDirection();
            _speed = entity.GetRotationSpeed();
        }

        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            if (_direction.Value == Vector3.zero)
                return;

            Quaternion targetRotation = Quaternion.LookRotation(_direction.Value);

            if (_rigidbody != null)
                _rigidbody.MoveRotation(Quaternion.Slerp(_rigidbody.rotation, targetRotation,
                    _speed.Value * deltaTime));
        }
    }
}