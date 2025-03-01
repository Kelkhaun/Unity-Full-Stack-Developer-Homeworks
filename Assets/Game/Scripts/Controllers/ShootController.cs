using Atomic.Contexts;
using Atomic.Entities;
using Modules.Common;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public class ShootController : IContextInit, IContextUpdate
    {
        private SceneEntity _character;
        private Joystick _aimJoystick;

        public void Init(IContext context)
        {
            _character = context.GetCharacter();
            _aimJoystick = context.GetAimJoystick();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            if (_aimJoystick.IsPressed && _aimJoystick.Direction != Vector2.zero)
                _character.GetShootingRequest().Invoke();
            else
                _character.GetShootingOverRequest().Invoke();
        }
    }
}