using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Shooting.UseCases;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class WeaponFiringBehaviour : IEntityInit<IWeaponEntity>, IEntityDispose<IWeaponEntity>
    {
        private IEvent _shootEvent;
        private IWeaponEntity _weapon;
    
        public void Init(IWeaponEntity entity)
        {
            _shootEvent = entity.GetShootEvent();
            _shootEvent.Subscribe(Shoot);
            _weapon = entity.GetWeapon();
        }

        public void Dispose(IWeaponEntity entity)
        {
            _shootEvent.Unsubscribe(Shoot);
        }

        private void Shoot()
        {
            _weapon.Fire();
        }
    }
}