using System;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class StatTimerAfterFireActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () =>
            {
                if (entity is IWeaponEntity weaponEntity)
                {
                    weaponEntity.GetShootTimer().ResetTime();
                    weaponEntity.GetShootTimer().Start();
                }
            };
        }
    }
}