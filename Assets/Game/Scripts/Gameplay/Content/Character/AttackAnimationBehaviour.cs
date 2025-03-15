using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

public sealed class AttackAnimationBehaviour : IEntityInit, IEntityDispose
{
    private static readonly int Attack = Animator.StringToHash("Attack");

    private Animator _animator;
    private ReactiveInt _health;
    private WeaponEntity _weapon;

    public void Init(in IEntity entity)
    {
        _animator = entity.GetAnimator();
        _weapon = entity.GetWeapon();
        _weapon.GetShootAction().Subscribe(OnShoot);
    }

    public void Dispose(in IEntity entity)
    {
        _weapon.GetShootAction().Unsubscribe(OnShoot);
    }

    private void OnShoot()
    {
        _animator.SetTrigger(Attack);
    }
}