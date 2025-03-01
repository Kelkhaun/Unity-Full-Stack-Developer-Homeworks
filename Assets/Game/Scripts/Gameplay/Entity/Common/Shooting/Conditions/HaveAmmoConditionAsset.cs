using System;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Conditions
{
    public class HaveAmmoConditionAsset : IEntityPredicateAsset
    {
        public Func<bool> Create(IEntity entity)
        {
            return () =>
            {
                if (entity is IWeaponEntity weaponEntity)
                {
                    return weaponEntity.GetBulletCount().Value > 0;
                }

                return false;
            };
        }
    }
}