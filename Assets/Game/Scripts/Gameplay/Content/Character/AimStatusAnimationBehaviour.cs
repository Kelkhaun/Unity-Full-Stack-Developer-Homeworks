using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class AimStatusAnimationBehaviour : IEntityInit, IEntityDispose
{
    private static readonly int IsAiming = Animator.StringToHash("IsAiming");

    private Animator _animator;
    private ReactiveBool _isAiming;

    public void Init(in IEntity entity)
    {
        _animator = entity.GetAnimator();
        _isAiming = entity.GetIsAiming();
        _isAiming.Observe(OnAimingStatusChanged);
    }

    public void Dispose(in IEntity entity)
    {
        _isAiming.Unsubscribe(OnAimingStatusChanged);
    }

    private void OnAimingStatusChanged(bool isAiming)
    {
        _animator.SetBool(IsAiming, isAiming);
    }
}