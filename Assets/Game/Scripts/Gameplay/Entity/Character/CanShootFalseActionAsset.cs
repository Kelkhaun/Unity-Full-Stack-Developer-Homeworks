using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class CanShootFalseActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () => entity.GetCanShoot().Value = false;
    }
}