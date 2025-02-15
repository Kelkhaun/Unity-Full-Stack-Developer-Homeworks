using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public sealed class Spider : MonoBehaviour
    {
        [SerializeField]
        private TimerComponent _pushTimerComponent;

        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private HealthComponent _healthComponent;

        [SerializeField]
        private DamageComponent _damageComponent;

        [SerializeField]
        private RotateComponent _rotateComponent;

        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        private TriggerComponent _triggerComponent;

        private void Awake()
        {
            _pushComponent.AddCondition(() => !_pushTimerComponent.IsOnCooldown);
        }

        private void OnEnable()
        {
            _healthComponent.OnHealthLost += Death;
            _moveComponent.OnMove += OnMove;
            _triggerComponent.OnEnter += OnEnter;
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthLost -= Death;
            _moveComponent.OnMove -= OnMove;
            _triggerComponent.OnEnter -= OnEnter;
        }

        private void OnEnter(GameObject triggeredGameObject)
        {
            _damageComponent.Attack(triggeredGameObject);
            _pushComponent.Push(triggeredGameObject);
        }

        private void OnMove(Vector3 direction)
        {
            _rotateComponent.Rotate(direction.x < 0
                ? RotateComponent.RotateDirection.Left
                : RotateComponent.RotateDirection.Right);
        }


        private void Death()
        {
            _healthComponent.gameObject.SetActive(false);
        }
    }
}