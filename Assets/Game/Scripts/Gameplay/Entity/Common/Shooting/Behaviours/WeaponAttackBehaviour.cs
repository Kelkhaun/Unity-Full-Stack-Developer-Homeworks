using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Ammo;
using Game.Scripts.Gameplay.Entity.Common.Shooting.UseCases;
using Game.Scripts.Types;
using Modules.Gameplay;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class WeaponAttackBehaviour : IEntityInit<IWeaponEntity>, IEntityDispose<IWeaponEntity>
    {
        private const string fireEvent = "fire_event";
        
        private IEvent _attackEvent;
        private IWeaponEntity _weapon;
        private WeaponType _weaponType;
        private BaseEvent _shootAction;
        private AnimationEventReceiver _reciever;

        public void Init(IWeaponEntity entity)
        {
            _attackEvent = entity.GetAttackEvent();
            _attackEvent.Subscribe(Shoot);
            _weapon = entity.GetWeapon();
            _weaponType = entity.GetWeaponType();
            _shootAction = entity.GetShootAction();
            _reciever = entity.GetAnimationEventReceiver();
            _reciever.Subscribe(fireEvent, OnShoot);
        }

        public void Dispose(IWeaponEntity entity)
        {
            _attackEvent.Unsubscribe(Shoot);
            _reciever.Unsubscribe(fireEvent, OnShoot);
        }

        private void Shoot()
        {
            _shootAction.Invoke();
        }

        private void OnShoot()
        {
            _weapon.Attack(_weaponType);
        }
    }
}