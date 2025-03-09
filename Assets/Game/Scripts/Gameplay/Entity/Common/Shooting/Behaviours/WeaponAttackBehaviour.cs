using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Ammo;
using Game.Scripts.Gameplay.Entity.Common.Shooting.UseCases;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class WeaponAttackBehaviour : IEntityInit<IWeaponEntity>, IEntityDispose<IWeaponEntity>
    {
        private IEvent _attackEvent;
        private IWeaponEntity _weapon;
        private WeaponType _weaponType;

        public void Init(IWeaponEntity entity)
        {
            _attackEvent = entity.GetAttackEvent();
            _attackEvent.Subscribe(Shoot);
            _weapon = entity.GetWeapon();
            _weaponType = entity.GetWeaponType();
        }

        public void Dispose(IWeaponEntity entity)
        {
            _attackEvent.Unsubscribe(Shoot);
        }

        private void Shoot()
        {
            _weapon.Attack(_weaponType);
        }
    }
}