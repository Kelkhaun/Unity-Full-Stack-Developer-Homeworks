using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class DestroySoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private DestroyerComponent _destroyerComponent;

        private void OnEnable()
        {
            _destroyerComponent.OnDestroy += OnDestroy;
        }

        private void OnDisable()
        {
            _destroyerComponent.OnDestroy -= OnDestroy;
        }

        private void OnDestroy()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}