using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Move
{
    public sealed class MovementBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private Rigidbody _rigidbody;
        private ReactiveVector3 _direction;
        private ReactiveFloat _speed;

        public void Init(in IEntity entity)
        {
            _rigidbody = entity.GetRigidbody();
            _speed = entity.GetMoveSpeed();
            _direction = entity.GetMoveDirection();
        }

        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            if (_rigidbody != null)
                _rigidbody.velocity = _direction.Value * (_speed.Value * deltaTime);
        }
    }
}