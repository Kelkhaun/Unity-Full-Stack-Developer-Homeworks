using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

public class CanShootTrueConditionAsset : IEntityPredicateAsset
{
    public Func<bool> Create(IEntity entity)
    {
        return () => entity.GetCanShoot().Value;
    }
}