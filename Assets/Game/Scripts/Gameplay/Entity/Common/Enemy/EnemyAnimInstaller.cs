using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public sealed class EnemyAnimInstaller : SceneEntityInstaller
    {
        private const string fireEvent = "fire_event";

        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private AnimationEventReceiver _animationReceiver;
        
        public override void Install(IEntity entity)
        {
            //TODO
        }
    }
}