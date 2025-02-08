using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Gameplay
{
    public sealed class CharacterCoreInstaller : SceneEntityInstaller
    {
        [SerializeField] private ReactiveFloat _moveSpeed;
        [SerializeField] private ReactiveFloat _rotationSpeed;
        [SerializeField] private ReactiveVector3 _direction;
        [SerializeField] private Rigidbody _rigidbody;

        public override void Install(IEntity entity)
        {
            //Body
            entity.AddTransform(transform);
            entity.AddRigidbody(_rigidbody);
            //Movement
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotationSpeed(_rotationSpeed);
            entity.AddDirection(_direction);
            entity.AddBehaviour<MovementBehaviour>();
            entity.AddBehaviour<RotationBehavior>();
        }
    }

    public class RotationBehavior : IEntityInit, IEntityFixedUpdate
    {
        private Rigidbody _rigidbody;
        private ReactiveVector3 _direction;
        private ReactiveFloat _speed;

        public void Init(in IEntity entity)
        {
            _rigidbody = entity.GetRigidbody();
            _direction = entity.GetDirection();
            _speed = entity.GetRotationSpeed();
        }

        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            if(_direction.Value == Vector3.zero )
                return;
            
            Quaternion targetRotation = Quaternion.LookRotation(_direction.Value);
            _rigidbody.MoveRotation(Quaternion.Slerp(_rigidbody.rotation, targetRotation, _speed.Value * deltaTime));
        }
    }
}