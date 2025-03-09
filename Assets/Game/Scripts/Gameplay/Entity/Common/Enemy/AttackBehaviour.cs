using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public class AttackBehaviour : IEntityInit, IEntityUpdate
    {
        private ReactiveBool _canHit;
        private WeaponEntity _weapon;

        public void Init(in IEntity entity)
        {
            _canHit = entity.GetCanHit();
            _weapon = entity.GetWeapon();
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (_canHit.Value)
                _weapon.GetAttackRequest().Invoke();
        }
    }
}