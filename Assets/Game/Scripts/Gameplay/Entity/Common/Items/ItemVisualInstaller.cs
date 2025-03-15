using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Items
{
    public sealed class ItemVisualInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private ParticleSystem _vfx;

        [SerializeField]
        private GameObject _visual;

        [SerializeField]
        private AudioSource _audioSource;
        
        public override void Install(IEntity entity)
        {
            entity.GetInteractableItemSuccess().Subscribe(() =>
            {
                _vfx.Play();
                _visual.gameObject.SetActive(false);
                _audioSource.Play();
            });
        }
    }
}