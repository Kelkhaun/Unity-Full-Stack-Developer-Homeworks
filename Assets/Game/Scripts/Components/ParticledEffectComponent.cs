using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class ParticledEffectComponent : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _particleSystem;

        public void PlayEffect()
        {
            _particleSystem.Play();
        }
    }
}