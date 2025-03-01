using Atomic.Contexts;
using Atomic.Entities;
using Modules.Common;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public class InputInstaller : SceneContextInstaller
    {
        [SerializeField] private Joystick _moveJoystick;
        [SerializeField] private Joystick _aimJoystick;
        [SerializeField] private SceneEntity _character;

        public override void Install(IContext context)
        {
            context.AddMoveJoystick(_moveJoystick);
            context.AddAimJoystick(_aimJoystick);
            context.AddCharacter(_character);
            context.AddController<MoveController>();
            context.AddController<AimController>();
            context.AddController<ShootController>();
        }
    }
}                                                                 

