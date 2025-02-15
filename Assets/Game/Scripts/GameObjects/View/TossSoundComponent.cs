using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class TossSoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private PushComponent _pushComponent;

        private void OnEnable()
        {
            _pushComponent.OnPush += OnToss;
        }

        private void OnDisable()
        {
            _pushComponent.OnPush -= OnToss;
        }

        private void OnToss()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}