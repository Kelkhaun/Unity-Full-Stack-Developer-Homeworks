using System;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Gameplay.Entity.Common.Move;
using Game.Scripts.Gameplay.Entity.Common.Rotation;
using Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours;

namespace Game.Scripts.Gameplay.Entity.Common.Projectile
{
    public class BehaviourRemoveActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () =>
            {
                entity.DelBehaviour<MovementBehaviour>();
                entity.DelBehaviour<RotationBehavior>();
                entity.DelBehaviour<AttackBehaviour>();
            };
        }
    }
}