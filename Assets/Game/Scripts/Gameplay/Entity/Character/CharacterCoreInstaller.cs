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
        [SerializeField] private ReactiveVector3 _moveDirection;
        [SerializeField] private ReactiveVector3 _rotateDirection;
        [SerializeField] private Rigidbody _rigidbody;

        public override void Install(IEntity entity)
        {
            //Body
            entity.AddTransform(transform);
            entity.AddRigidbody(_rigidbody);
            //Movement
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotationSpeed(_rotationSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddRotateDirection(_rotateDirection);
            entity.AddBehaviour<MovementBehaviour>();
            entity.AddBehaviour<RotationBehavior>();
        }
    }
}