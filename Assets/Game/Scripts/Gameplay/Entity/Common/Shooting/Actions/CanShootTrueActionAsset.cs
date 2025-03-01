using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class CanShootTrueActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () => entity.GetCanShoot().Value = true;
        }
    }
}