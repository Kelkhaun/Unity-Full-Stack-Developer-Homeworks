using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public sealed class DeathController : MonoBehaviour
    {
        [SerializeField]
        private HealthComponent _healthComponent;

        private void OnEnable()
        {
            _healthComponent.OnHealthLost.AddListener(Death);
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthLost.RemoveListener(Death);
        }

        private void Death()
        {
            _healthComponent.gameObject.SetActive(false);
        }
    }
}