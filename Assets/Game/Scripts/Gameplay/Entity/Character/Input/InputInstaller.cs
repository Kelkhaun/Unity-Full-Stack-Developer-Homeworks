using Atomic.Contexts;
using Atomic.Entities;
using Modules.Common;
using SampleGame;
using UnityEngine;

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
    }
}