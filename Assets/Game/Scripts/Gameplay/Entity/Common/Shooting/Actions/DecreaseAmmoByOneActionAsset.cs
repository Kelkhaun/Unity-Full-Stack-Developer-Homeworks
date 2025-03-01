using System;
using Atomic.Entities;
using Atomic.Extensions;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Actions
{
    public class DecreaseAmmoByOneActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () =>
            {
                if (entity is IWeaponEntity weaponEntity)
                {
                    weaponEntity.GetBulletCount().Value -= 1;
                }
            };
        }
    }
}