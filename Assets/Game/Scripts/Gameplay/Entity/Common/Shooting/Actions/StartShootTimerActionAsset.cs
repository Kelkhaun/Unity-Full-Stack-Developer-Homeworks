using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class StartShootTimerActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () =>
        {
            if (entity.GetCanShoot().Value == false)
                entity.GetShootTimer().Start();
        };
    }
}