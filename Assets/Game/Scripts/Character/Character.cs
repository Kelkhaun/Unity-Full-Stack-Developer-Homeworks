using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Character
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField]
        private HealthComponent _healthComponent;

        [SerializeField]
        private JumpComponent _jumpComponent;

        [SerializeField]
        private TimerComponent _jumpTimerComponent;

        [SerializeField]
        private GroundedComponent _groundedComponent;

        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private TimerComponent _pushTimerComponent;

        [SerializeField]
        private PushComponent _tossComponent;

        [SerializeField]
        private TimerComponent _tossTimerComponent;

        private void Start()
        {
            _jumpComponent.AddCondition(() => !_jumpTimerComponent.IsOnCooldown);
            _jumpComponent.AddCondition(() => _groundedComponent.IsGrounded);
            _jumpComponent.AddCondition(() => _healthComponent.IsAlive);
            _pushComponent.AddCondition(() => !_pushTimerComponent.IsOnCooldown);
            _pushComponent.AddCondition(() => _healthComponent.IsAlive);

            _tossComponent.AddCondition(() => !_tossTimerComponent.IsOnCooldown);
            _tossComponent.AddCondition(() => _groundedComponent.IsGrounded);
            _tossComponent.AddCondition(() => _healthComponent.IsAlive);
        }
    }
}