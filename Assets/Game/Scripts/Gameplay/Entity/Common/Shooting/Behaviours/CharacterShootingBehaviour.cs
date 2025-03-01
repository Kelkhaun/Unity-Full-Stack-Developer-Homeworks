using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class CharacterShootingBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent _shootEvent;
        private IWeaponEntity _weapon;
    
        public void Init(in IEntity entity)
        {
            _shootEvent = entity.GetShootEvent();
            _shootEvent.Subscribe(Shoot);
            _weapon = entity.GetWeapon();
        }

        public void Dispose(in IEntity entity)
        {
            _shootEvent.Unsubscribe(Shoot);
        }

        private void Shoot()
        {
            _weapon.GetShootingRequest().Invoke();
        }
    }
}