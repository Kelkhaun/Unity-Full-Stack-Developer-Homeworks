using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
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
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeReference] private IEntityPredicateAsset[] _shootConditions;
        [SerializeReference] private IEntityActionAsset[] _shootRequestActions;
        [SerializeReference] private IEntityActionAsset[] _shootOverActions;
        [SerializeField] private Countdown _shootTimer;
        
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
            //Shooting
            entity.AddCanShoot(new ReactiveBool());
            entity.AddShootTimer(_shootTimer);
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddShootPoint(_shootPoint);
            entity.AddBehaviour<ShootingBulletBehaviour>();
            entity.AddBehaviour<ShootingBehaviour>();
            entity.AddBehaviour<StartShootDelayBehaviour>();
            //ShootingEvent
            BaseEvent shootRequestEvent = new BaseEvent();
            shootRequestEvent.SubscribeAllBy(_shootRequestActions, entity);
            entity.AddShootingRequest(shootRequestEvent);
            AndExpression condition = new AndExpression();
            entity.AddShootingCondition(condition);
            condition.AppendBy(_shootConditions, entity);
            entity.AddShootEvent(new BaseEvent());
            BaseEvent shootOverEvent = new BaseEvent();
            shootOverEvent.SubscribeAllBy(_shootOverActions, entity);
            entity.AddShootingOverRequest(shootOverEvent);
        }
    }
}