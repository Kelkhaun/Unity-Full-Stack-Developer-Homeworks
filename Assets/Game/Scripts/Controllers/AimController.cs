using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Modules.Common;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public class AimController : IContextInit, IContextUpdate
    {
        private SceneEntity _character;
        private Joystick _moveJoystick;
        private Joystick _aimJoystick;
        private ReactiveVector3 _rotateDirection;
        private ReactiveBool _isAiming;
        private Vector3 _transformedDirection;
        private Joystick _activeJoystick;
    
        public void Init(IContext context)
        {
            _character = context.GetCharacter();
            _moveJoystick = context.GetMoveJoystick();
            _aimJoystick = context.GetAimJoystick();
            _rotateDirection = _character.GetRotateDirection();
            _isAiming = _character.GetIsAiming();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _activeJoystick = _aimJoystick.IsPressed ? _aimJoystick : _moveJoystick;
            _transformedDirection = new Vector3(_activeJoystick.Direction.x, 0, _activeJoystick.Direction.y);
            _rotateDirection.Value = _transformedDirection;
            
            _isAiming.Value = _aimJoystick.IsPressed;
        }
    }
}