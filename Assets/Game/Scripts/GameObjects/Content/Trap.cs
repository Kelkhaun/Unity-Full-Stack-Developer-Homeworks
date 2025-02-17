using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public class Trap : MonoBehaviour
    {
        [SerializeField]
        private DamageComponent _damageComponent;

        [SerializeField]
        private HealthComponent _healthComponent;

        [SerializeField]
        private TriggerComponent _triggerComponent;

        private void OnEnable()
        {
            _healthComponent.OnHealthLost += Death;
            _triggerComponent.OnEnter += OnEnter;
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthLost -= Death;
            _triggerComponent.OnEnter -= OnEnter;
        }

        private void OnEnter(GameObject triggedGameObject)
        {
            _damageComponent.Attack(triggedGameObject);

            if (triggedGameObject.TryGetComponent(out Character character))
                _healthComponent.Die();
        }

        private void Death()
        {
            _healthComponent.gameObject.SetActive(false);
        }
    }
}