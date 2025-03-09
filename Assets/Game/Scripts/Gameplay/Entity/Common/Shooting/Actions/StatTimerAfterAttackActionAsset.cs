using System;
using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class StatTimerAfterAttackActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () =>
            {
                if (entity is IWeaponEntity weaponEntity)
                {
                    Countdown attackCooldown = weaponEntity.GetAttackCooldown();
                    attackCooldown.ResetTime();
                    attackCooldown.Start();
                }
            };
        }
    }
}