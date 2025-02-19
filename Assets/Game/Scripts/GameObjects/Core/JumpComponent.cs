using System;
using Game.Scripts.Common;
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
        private Timer timer;

        public event Action OnJump;

        private void Awake()
        {
            AddCondition(() => !timer.IsOnCooldown);
        }

        private void Update()
        {
            timer.Tick();
        }

        public void Jump()
        {
            if (!CompositeCondition.IsTrue())
                return;

            timer.StartWork();
            _rigidbody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
            OnJump?.Invoke();
        }
    }
}