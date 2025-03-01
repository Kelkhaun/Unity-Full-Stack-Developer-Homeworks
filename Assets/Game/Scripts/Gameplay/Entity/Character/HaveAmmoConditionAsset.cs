using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;
using UnityEngine.TextCore.Text;

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