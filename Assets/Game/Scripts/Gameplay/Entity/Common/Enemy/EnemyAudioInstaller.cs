using Atomic.Entities;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public sealed class EnemyAudioInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip[] _deathClips;

        [SerializeField]
        private AudioClip[] _attackClips;

        [SerializeField]
        private AudioClip[] _damageClips;

        [SerializeField]
        private AudioClip _bodyFallClip;

        [SerializeField]
        private AudioClip _meleeDamageClip;

        [SerializeField]
        private AudioClip _bulletDamageClip;
        
        public override void Install(IEntity entity)
        {
            //TODO
        }
    }
}