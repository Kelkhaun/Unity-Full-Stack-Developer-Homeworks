using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class ParticlePushEffectComponent : MonoBehaviour
    {
        [SerializeField]
        private PushComponent _pushComponent; 

        [SerializeField]
        private ParticleSystem _particleSystem;

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
            _particleSystem.Play();
        }
    }
}