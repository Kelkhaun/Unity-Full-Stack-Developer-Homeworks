using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public class DirectionSetBehavior : IEntityInit, IEntityFixedUpdate
{
    private ReactiveVector3 _moveDirection;
    private ReactiveVector3 _rotateDirection;
    private ReactiveVariable<IEntity> _targetEntity;
    private Rigidbody _rigidbody;
    private ReactiveFloat _minDistance;

    public void Init(in IEntity entity)
    {
        _moveDirection = entity.GetMoveDirection();
        _rotateDirection = entity.GetRotateDirection();
        _targetEntity = entity.GetTarget();
        _rigidbody = entity.GetRigidbody();
        _minDistance = entity.GetMinDistance();
    }

    public void OnFixedUpdate(in IEntity entity, in float deltaTime)
    {
        if (_targetEntity.Value == null)
        {
            _moveDirection.Value = Vector3.zero;
            _rotateDirection.Value = Vector3.zero;
        }
        else
        {
            Vector3 targetDirection = (_targetEntity.Value.GetRigidbody().position - _rigidbody.position);
            Vector3 normalizedTargetDirection = targetDirection.normalized;

            _moveDirection.Value = targetDirection.sqrMagnitude <= _minDistance.Value * _minDistance.Value
                ? Vector3.zero
                : normalizedTargetDirection;

            _rotateDirection.Value = normalizedTargetDirection;
        }
    }
}