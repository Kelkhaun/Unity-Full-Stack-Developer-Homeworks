using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class SoundEffectComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        public void PlaySound()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}