using Game.Scripts.GameContext;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public sealed class Character : MonoBehaviour, IPushComponent, ITossComponent
    {
        [SerializeField]
        private HealthComponent _healthComponent;

        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        private RotateComponent _rotateComponent;

        [SerializeField]
        private JumpComponent _jumpComponent;

        [SerializeField]
        private GroundedComponent _groundedComponent;

        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private PushComponent _tossComponent;

        private void OnEnable()
        {
            _healthComponent.OnHealthLost += Death;
            _moveComponent.OnMove += OnMove;
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthLost -= Death;
            _moveComponent.OnMove -= OnMove;
        }

        private void OnMove(Vector3 direction)
        {
            if (Mathf.Abs(direction.x - 1) < float.Epsilon)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Right);

            if (Mathf.Abs(direction.x + 1) < float.Epsilon)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Left);
        }

        public void Push()
        {
            _pushComponent.Push();
        }

        public void Toss()
        {
            _tossComponent.Push();
        }

        private void Death()
        {
            _healthComponent.gameObject.SetActive(false);
        }

        private void Start()
        {
            _jumpComponent.AddCondition(() => _groundedComponent.IsGrounded);
            _jumpComponent.AddCondition(() => _healthComponent.IsAlive);
            _pushComponent.AddCondition(() => _healthComponent.IsAlive);
            _tossComponent.AddCondition(() => _groundedComponent.IsGrounded);
            _tossComponent.AddCondition(() => _healthComponent.IsAlive);
        }
    }
}