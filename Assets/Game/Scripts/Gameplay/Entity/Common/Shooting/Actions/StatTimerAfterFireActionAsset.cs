using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class StatTimerAfterFireActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () =>
        {
            if (entity is IWeaponEntity weaponEntity)
            {
                weaponEntity.GetShootTimer().ResetTime();
                weaponEntity.GetShootTimer().Start();
            }
        };
    }
}