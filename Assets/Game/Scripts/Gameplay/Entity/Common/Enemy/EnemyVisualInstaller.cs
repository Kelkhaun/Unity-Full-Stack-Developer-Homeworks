using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class EnemyVisualInstaller : SceneEntityInstaller
{
    [SerializeField] private Animator _animator;

    public override void Install(IEntity entity)
    {
        entity.AddAnimator(_animator);

        entity.AddBehaviour<DeathAnimationBehaviour>();
        entity.AddBehaviour<MoveAnimationBehaviour>();
        entity.AddBehaviour<TakeDamageAnimationBehaviour>();
    }
}