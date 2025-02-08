using Game.Scripts.Components.Conditions;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components
{
    public sealed class JumpComponent : ConditionComponent
    {
        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private float _jumpForce;

        public UnityEvent OnJump;

        public void Jump()
        {
            if (!CompositeCondition.IsTrue())
                return;

            _rigidbody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
            OnJump?.Invoke();
        }
    }
}