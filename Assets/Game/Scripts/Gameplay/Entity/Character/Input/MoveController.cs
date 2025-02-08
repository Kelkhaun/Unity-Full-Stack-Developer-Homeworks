using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Modules.Common;
using SampleGame;
using UnityEngine;

public class MoveController : IContextInit, IContextUpdate
{
    private SceneEntity _character;
    private Joystick _moveJoystick;
    private ReactiveVector3 _moveDirection;
    private Vector3 _transformedDirection;
    
    public void Init(IContext context)
    {
        _character = context.GetCharacter();
        _moveJoystick = context.GetMoveJoystick();
        _moveDirection = _character.GetMoveDirection();
    }

    public void OnUpdate(IContext context, float deltaTime)
    {
        _transformedDirection = new Vector3(_moveJoystick.Direction.x, 0, _moveJoystick.Direction.y);
        _moveDirection.Value = _transformedDirection;
    }
}