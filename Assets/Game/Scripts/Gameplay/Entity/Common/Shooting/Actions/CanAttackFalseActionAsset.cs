using System;
using Atomic.Entities;
using Atomic.Extensions;
using JetBrains.Annotations;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class CanAttackFalseActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () => entity.GetCanAttack().Value = false;
        }
    }
}