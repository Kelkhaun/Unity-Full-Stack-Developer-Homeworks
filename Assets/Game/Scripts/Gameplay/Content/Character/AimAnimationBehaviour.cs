using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class AimAnimationBehaviour : IEntityInit, IEntityDispose
{
    private static readonly int AimX = Animator.StringToHash("AimX");
    private static readonly int AimZ = Animator.StringToHash("AimZ");
    
    private Animator _animator;
    private IReactiveValue<Vector3> _moveDirection;
    
    public void Init(in IEntity entity)
    {
        _animator = entity.GetAnimator();
        _moveDirection = entity.GetRotateDirection();
        _moveDirection.Observe(OnMoveDirectionChanged);
    }

    public void Dispose(in IEntity entity)
    {
        _moveDirection.Unsubscribe(OnMoveDirectionChanged);    
    }

    private void OnMoveDirectionChanged(Vector3 direction)
    {
        _animator.SetFloat(AimX, direction.x);
        _animator.SetFloat(AimZ, direction.z);
    }
}