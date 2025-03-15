using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class DeathAnimationBehaviour : IEntityInit, IEntityDispose
{
    private static readonly int Death = Animator.StringToHash("Death");

    private Animator _animator;
    private ReactiveInt _health;

    public void Init(in IEntity entity)
    {
        _animator = entity.GetAnimator();
        _health = entity.GetCurrentHealth();
        _health.Observe(OnHealthChanged);
    }

    public void Dispose(in IEntity entity)
    {
        _health.Unsubscribe(OnHealthChanged);
    }

    private void OnHealthChanged(int health)
    {
        if (health == 0)
            _animator.SetTrigger(Death);
    }
}