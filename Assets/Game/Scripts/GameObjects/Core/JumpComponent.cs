using System;
using Game.Scripts.GameObjects.Core.Conditions;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class JumpComponent : ConditionComponent
    {
        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private float _jumpForce;

        [SerializeField]
        private TimerComponent _timerComponent;

        public event Action OnJump;

        private void Awake()
        {
            AddCondition(() => !_timerComponent.IsOnCooldown);
        }

        private void Update()
        {
            _timerComponent.Tick();
        }

        public void Jump()
        {
            if (!CompositeCondition.IsTrue())
                return;

            _timerComponent.StartWork();
            _rigidbody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
            OnJump?.Invoke();
        }
    }
}