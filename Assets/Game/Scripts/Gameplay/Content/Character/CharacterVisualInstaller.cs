using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Content.Character
{
    public sealed class CharacterVisualInstaller : SceneEntityInstaller
    {
        [SerializeField] private Animator _animator;
            
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);

            entity.AddBehaviour<MoveAnimationBehaviour>();
            entity.AddBehaviour<AimAnimationBehaviour>();
            entity.AddBehaviour<AimStatusAnimationBehaviour>();
            entity.AddBehaviour<TakeDamageAnimationBehaviour>();
            entity.AddBehaviour<DeathAnimationBehaviour>();
            entity.AddBehaviour<AttackAnimationBehaviour>();
        }
    }
}