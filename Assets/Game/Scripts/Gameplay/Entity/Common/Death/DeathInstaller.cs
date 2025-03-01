using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Death
{
    public sealed class DeathInstaller : SceneEntityInstaller
    {
        [SerializeReference]
        private IEntityActionAsset[] _deathActionAsset;

        override public void Install(IEntity entity)
        {
            BaseEvent deathEvent = new BaseEvent();
            deathEvent.SubscribeAllBy(_deathActionAsset, entity);
            entity.AddDeathEvent(deathEvent);
            entity.AddBehaviour<DeathBehaviour>();
        }
    }
}