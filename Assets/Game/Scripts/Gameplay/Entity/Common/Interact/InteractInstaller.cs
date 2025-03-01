using Atomic.Entities;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Interact
{
    public sealed class InteractInstaller  : SceneEntityInstaller
    {
        [SerializeField]
        private TriggerEventReceiver _triggerEventReceiver;

        override public void Install(IEntity entity)
        {
            entity.AddTriggerEventReceiver(_triggerEventReceiver);
            entity.AddBehaviour<InteractBehaviour>();
        }
    }
}