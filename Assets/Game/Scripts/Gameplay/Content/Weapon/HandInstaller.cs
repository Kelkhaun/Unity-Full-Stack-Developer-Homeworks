using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Content.Weapon
{
    public class HandInstaller : SceneEntityInstaller<IWeaponEntity>
    {
        [SerializeField]
        private WeaponEntity _weapon;

        [SerializeField]
        private Transform _firePoint;

        [SerializeField]
        private Countdown _attackTimer;

        [SerializeField]
        private ReactiveInt _damage;

        [SerializeField]
        private WeaponType _weaponType;

        [SerializeReference] private IEntityPredicateAsset[] _attackConditions;
        [SerializeReference] private IEntityActionAsset[] _attackActions;

        protected override void Install(IWeaponEntity entity)
        {
            entity.AddFirePoint(_firePoint);

            entity.AddDamage(_damage);    
            entity.AddWeapon(_weapon);
            entity.AddWeaponType(_weaponType);
            entity.AddAttackCooldown(_attackTimer);
            entity.AddCanAttack(new ReactiveBool(true));
            entity.AddBehaviour<CanAttackDelayBehaviour>();
            entity.AddBehaviour<AttackBehaviour>();
            entity.AddBehaviour<WeaponAttackBehaviour>();
            //Event
            BaseEvent shootRequestEvent = new BaseEvent();
            entity.AddAttackRequest(shootRequestEvent);

            AndExpression condition = new AndExpression();
            condition.AppendBy(_attackConditions, entity);
            entity.AddAttackCondition(condition);

            BaseEvent shootEvent = new BaseEvent();
            shootEvent.SubscribeAllBy(_attackActions, entity);
            entity.AddAttackEvent(shootEvent);
        }
    }
}