using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Modules.Gameplay;
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
        [SerializeReference] private IEntityPredicateAsset[] _shootConditions;
        [SerializeReference] private IEntityActionAsset[] _shootRequestActions;
        [SerializeReference] private IEntityActionAsset[] _shootOverActions;
        [SerializeField] private Countdown _shootTimer;
        [SerializeField] private WeaponEntity _currentWeapon;
        [SerializeField] private TriggerEventReceiver _triggerEventReceiver;

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
            entity.AddWeapon(_currentWeapon);
            entity.AddShootTimer(_shootTimer);
            entity.AddCanShoot(new ReactiveBool());
            entity.AddBehaviour<CanShootDelayBehaviour>();
            entity.AddBehaviour<ShootingBehaviour>();
            entity.AddBehaviour<CharacterShootingBehaviour>();
            //Event
            BaseEvent shootRequestEvent = new BaseEvent();
            shootRequestEvent.SubscribeAllBy(_shootRequestActions, entity);
            entity.AddShootingRequest(shootRequestEvent);
          
            AndExpression condition = new AndExpression();
            condition.AppendBy(_shootConditions, entity);
            entity.AddShootingCondition(condition);
            
            entity.AddShootEvent(new BaseEvent());
            
            BaseEvent shootOverEvent = new BaseEvent();
            shootOverEvent.SubscribeAllBy(_shootOverActions, entity);
            entity.AddShootingOverRequest(shootOverEvent);

            // Interact 
            entity.AddTriggerEventReceiver(_triggerEventReceiver);
            entity.AddBehaviour<InteractBehaviour>();
        }
    }
}