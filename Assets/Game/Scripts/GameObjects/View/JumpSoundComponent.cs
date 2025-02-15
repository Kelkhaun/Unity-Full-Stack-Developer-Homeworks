using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class JumpSoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private JumpComponent _jumpComponent;

        private void OnEnable()
        {
            _jumpComponent.OnJump += OnHealthChanged;
        }

        private void OnDisable()
        {
            _jumpComponent.OnJump -= OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}