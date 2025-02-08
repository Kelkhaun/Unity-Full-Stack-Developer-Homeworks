using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public class MovementBehaviour : IEntityInit, IEntityFixedUpdate
{
    private Rigidbody _rigidbody;
    private ReactiveVector3 _direction;
    private ReactiveFloat _speed;


    public void Init(in IEntity entity)
    {
        _rigidbody = entity.GetRigidbody();
        _speed = entity.GetMoveSpeed();
        _direction = entity.GetDirection();
    }

    public void OnFixedUpdate(in IEntity entity, in float deltaTime)
    {
        _rigidbody.velocity += _direction.Value * (_speed.Value * deltaTime);
    }
}