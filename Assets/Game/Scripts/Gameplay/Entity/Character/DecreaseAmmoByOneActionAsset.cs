using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class DecreaseAmmoByOneActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () =>
        {
            if (entity is IWeaponEntity weaponEntity)
            {
                weaponEntity.GetBulletCount().Value -= 1;
            }
        };
    }
}