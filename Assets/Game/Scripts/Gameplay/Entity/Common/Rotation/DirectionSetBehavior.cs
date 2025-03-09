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

    public void Init(in IEntity entity)
    {
        _moveDirection = entity.GetMoveDirection();
        _rotateDirection = entity.GetRotateDirection();
        _targetEntity = entity.GetTarget();
        _rigidbody = entity.GetRigidbody();
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
            Vector3 targetDirection = _targetEntity.Value.GetRigidbody().position - _rigidbody.position;
            _moveDirection.Value = targetDirection;
            _rotateDirection.Value = targetDirection;
        }
    }
}