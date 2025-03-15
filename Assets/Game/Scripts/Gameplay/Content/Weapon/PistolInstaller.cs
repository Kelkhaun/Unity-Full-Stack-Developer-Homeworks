using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours;
using Game.Scripts.Types;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Content.Weapon
{
    public class PistolInstaller : SceneEntityInstaller<IWeaponEntity>
    {
        [SerializeField]
        private WeaponEntity _weapon;

        [SerializeField]
        private Transform _firePoint;

        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField]
        private Countdown _fireTimer;

        [SerializeField]
        private ReactiveFloat _fireSpread;

        [SerializeField]
        private ReactiveInt _currentBulletCount;

        [SerializeReference]
        private IEntityPredicateAsset[] _fireConditions;

        [SerializeReference]
        private IEntityActionAsset[] _fireActions;

        [SerializeField]
        private WeaponType _weaponType;

        [SerializeField]
        private AnimationEventReceiver _eventReceiver;

        [SerializeField]
        private ParticleSystem _shootParticle;

        [SerializeField]
        private AudioSource _shootAudioSource;

        protected override void Install(IWeaponEntity entity)
        {
            //Data
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddFirePoint(_firePoint);
            entity.AddFireSpread(_fireSpread);
            entity.AddBulletCount(_currentBulletCount);
            //Shooting
            entity.AddWeapon(_weapon);
            entity.AddWeaponType(_weaponType);
            entity.AddAttackCooldown(_fireTimer);
            entity.AddCanAttack(new ReactiveBool(true));
            entity.AddBehaviour<CanAttackDelayBehaviour>();
            entity.AddBehaviour<AttackBehaviour>();
            entity.AddBehaviour<WeaponAttackBehaviour>();
            entity.AddShootAction(new BaseEvent());
            entity.AddAnimationEventReceiver(_eventReceiver);
            //Event
            BaseEvent shootRequestEvent = new BaseEvent();
            entity.AddAttackRequest(shootRequestEvent);

            AndExpression condition = new AndExpression();
            condition.AppendBy(_fireConditions, entity);
            entity.AddAttackCondition(condition);

            BaseEvent shootEvent = new BaseEvent();
            shootEvent.SubscribeAllBy(_fireActions, entity);
            entity.AddAttackEvent(shootEvent);

            entity.GetShootAction()
                .Subscribe(() =>
                {
                    _shootAudioSource.Play();
                    _shootParticle.Play();
                });
        }
    }
}