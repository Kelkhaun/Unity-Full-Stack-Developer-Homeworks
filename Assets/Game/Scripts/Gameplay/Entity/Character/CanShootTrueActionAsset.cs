using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class CanShootTrueActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () => entity.GetCanShoot().Value = true;
    }
}