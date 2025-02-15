using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class HealthChangedSoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private HealthComponent _healthComponent;

        private void OnEnable()
        {
            _healthComponent.OnHealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}