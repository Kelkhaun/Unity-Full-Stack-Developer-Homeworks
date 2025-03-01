using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;
using Object = UnityEngine.Object;

namespace Game.Scripts.Gameplay.Entity.Common.Projectile
{
    public class GameObjectDestroyActionAsset : IEntityActionAsset
    {
        public Action Create(IEntity entity)
        {
            return () => Object.Destroy(entity.GetGameObject());
        }
    }
}