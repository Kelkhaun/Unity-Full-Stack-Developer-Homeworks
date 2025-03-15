using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class TakeDamageAnimationBehaviour : IEntityInit, IEntityDispose
{
    private static readonly int TakeDamage = Animator.StringToHash("TakeDamage");

    private Animator _animator;
    private ReactiveInt _health;

    private int _oldHealth;

    public void Init(in IEntity entity)
    {
        _animator = entity.GetAnimator();
        _health = entity.GetCurrentHealth();
        _health.Observe(OnHealthChanged);
        _oldHealth = _health.Value;
    }

    public void Dispose(in IEntity entity)
    {
        _health.Unsubscribe(OnHealthChanged);
    }

    private void OnHealthChanged(int health)
    {
        if (_oldHealth > health)
            _animator.SetTrigger(TakeDamage);
        
        _oldHealth = health;
    }
}