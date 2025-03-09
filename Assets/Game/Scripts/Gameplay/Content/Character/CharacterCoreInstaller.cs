using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Gameplay.Entity.Common.Move;
using Game.Scripts.Gameplay.Entity.Common.Rotation;
using Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Content.Character
{
    public sealed class CharacterCoreInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private ReactiveFloat _moveSpeed;

        [SerializeField]
        private ReactiveFloat _rotationSpeed;

        [SerializeField]
        private ReactiveVector3 _moveDirection;

        [SerializeField]
        private ReactiveVector3 _rotateDirection;

        [SerializeField]
        private Rigidbody _rigidbody;

        [SerializeReference]
        private IEntityPredicateAsset[] _shootConditions;

        [SerializeReference]
        private IEntityActionAsset[] _shootRequestActions;

        [SerializeReference]
        private IEntityActionAsset[] _shootOverActions;

        [SerializeField]
        private Countdown _shootTimer;

        [SerializeField]
        private WeaponEntity _currentWeapon;

        public override void Install(IEntity entity)
        { 
            //Body
            entity.AddTransform(transform);
            entity.AddRigidbody(_rigidbody);
            entity.AddGameObject(gameObject);
            //Movement
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotationSpeed(_rotationSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddRotateDirection(_rotateDirection);
            entity.AddBehaviour<MovementBehaviour>();
            entity.AddBehaviour<RotationBehavior>();
            //Shooting
            entity.AddWeapon(_currentWeapon);
            entity.AddAttackCooldown(_shootTimer);
            entity.AddCanAttack(new ReactiveBool());
            entity.AddBehaviour<CanAttackDelayBehaviour>();
            entity.AddBehaviour<AttackBehaviour>();
            entity.AddBehaviour<CharacterShootingBehaviour>();
            //Event
            BaseEvent shootRequestEvent = new BaseEvent();
            shootRequestEvent.SubscribeAllBy(_shootRequestActions, entity);
            entity.AddAttackRequest(shootRequestEvent);

            AndExpression condition = new AndExpression();
            condition.AppendBy(_shootConditions, entity);
            entity.AddAttackCondition(condition);

            entity.AddAttackEvent(new BaseEvent());

            BaseEvent shootOverEvent = new BaseEvent();
            shootOverEvent.SubscribeAllBy(_shootOverActions, entity);
            entity.AddAttackOverRequest(shootOverEvent);
        }
    }
}