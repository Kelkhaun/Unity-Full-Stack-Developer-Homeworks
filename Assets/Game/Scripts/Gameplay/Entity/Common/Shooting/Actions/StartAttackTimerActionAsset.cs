using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class StartAttackTimerActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () =>
            {
                if (entity.GetCanAttack().Value == false)
                    entity.GetAttackCooldown().Start();
            };
        }
    }
}