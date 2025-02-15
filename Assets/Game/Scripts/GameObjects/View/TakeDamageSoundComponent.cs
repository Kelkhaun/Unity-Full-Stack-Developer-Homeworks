using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
{
    public sealed class TakeDamageSoundComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _clip;

        [SerializeField]
        private DamageComponent _damageComponent;

        private void OnEnable()
        {
            _damageComponent.OnAttack += OnAttack;
        }

        private void OnDisable()
        {
            _damageComponent.OnAttack -= OnAttack;
        }

        private void OnAttack()
        {
            _audioSource.PlayOneShot(_clip);
        }
    }
}