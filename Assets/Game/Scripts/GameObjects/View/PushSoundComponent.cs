using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class PushSoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private PushComponent _pushComponent;

        private void OnEnable()
        {
            _pushComponent.OnPush += OnPush;
        }

        private void OnDisable()
        {
            _pushComponent.OnPush -= OnPush;
        }

        private void OnPush()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}