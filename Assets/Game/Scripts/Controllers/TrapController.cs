using Game.Scripts.Components;
using Game.Scripts.Components.Finders;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public class TrapController : MonoBehaviour
    {
        [SerializeField]
        private ColliderFinder _colliderFinder;

        [SerializeField]
        private DamageComponent _damageComponent;

        [SerializeField]
        private HealthComponent _healthComponent;

        private void OnEnable()
        {
            _colliderFinder.OnTargetAdd.AddListener(OnTargetAdd);
        }

        private void OnDisable()
        {
            _colliderFinder.OnTargetAdd.RemoveListener(OnTargetAdd);
        }

        private void OnTargetAdd()
        {
            var targets = _colliderFinder.GetTargets();

            foreach (var target in targets)
            {
                _damageComponent.Attack(target);
            }

            _healthComponent.Die();
        }
    }
}