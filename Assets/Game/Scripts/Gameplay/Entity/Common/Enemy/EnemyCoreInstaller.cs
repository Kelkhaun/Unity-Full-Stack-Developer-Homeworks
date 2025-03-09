using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Move;
using Game.Scripts.Gameplay.Entity.Common.Rotation;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public sealed class EnemyCoreInstaller : SceneEntityInstaller
    {
        [Header("Movement")]

        [SerializeField]
        private Rigidbody _rigibody;

        [SerializeField]
        private ReactiveFloat _speed;

        [SerializeField]
        private ReactiveFloat _rotationSpeed;

        [Header("Weapon"), Space(3)]
        [SerializeField]
        private WeaponEntity _currentWeapon;

        public override void Install(IEntity entity)
        {
            entity.AddEnemyTag();
            entity.AddGameObject(this.gameObject);
            entity.AddTarget(new ReactiveVariable<IEntity>());
            //Movement
            entity.AddRigidbody(_rigibody);
            entity.AddMoveSpeed(_speed);
            entity.AddMoveDirection(new ReactiveVector3());
            entity.AddBehaviour<MovementBehaviour>();
            //Rotation
            entity.AddRotationSpeed(_rotationSpeed);
            entity.AddRotateDirection(new ReactiveVector3());
            entity.AddBehaviour<RotationBehavior>();
            //DirectionsSetter
            entity.AddBehaviour<DirectionSetBehavior>();

            // Weapon
            entity.AddWeapon(_currentWeapon);
            entity.AddCanHit(new ReactiveBool());
            entity.AddMinDistance(new ReactiveFloat(1f));
            entity.AddBehaviour<CanHitSetBehaviour>();
            entity.AddBehaviour<AttackBehaviour>();
        }
    }
}