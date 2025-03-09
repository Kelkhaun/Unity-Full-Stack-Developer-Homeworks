using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Conditions
{
    public class CanAttackTrueConditionAsset : IEntityPredicateAsset
    {
        public Func<bool> Create(IEntity entity)
        {
            return () => entity.GetCanAttack().Value;
        }
    }
}