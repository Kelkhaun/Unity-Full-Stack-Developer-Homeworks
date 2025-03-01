using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Conditions
{
    public class CanShootTrueConditionAsset : IEntityPredicateAsset
    {
        public Func<bool> Create(IEntity entity)
        {
            return () => entity.GetCanShoot().Value;
        }
    }
}