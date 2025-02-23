using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public class BulletMoveDirectionBehavior : IEntityInit, IEntityUpdate
{
    private ReactiveVector3 _direction;
    private Transform _transform;

    public void Init(in IEntity entity)
    {
        _transform = entity.GetTransform();
        _direction = entity.GetMoveDirection();
    }

    public void OnUpdate(in IEntity entity, in float deltaTime)
    {
        _direction.Value = _transform.forward;
    }
}