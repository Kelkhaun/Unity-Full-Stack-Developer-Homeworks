using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField]
        private HealthComponent _healthComponent;

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
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthLost -= Death;
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