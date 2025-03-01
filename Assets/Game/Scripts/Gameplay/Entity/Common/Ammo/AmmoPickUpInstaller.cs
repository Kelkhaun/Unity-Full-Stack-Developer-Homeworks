using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Ammo
{
    public sealed class AmmoPickUpInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _clips = 10;

        override public void Install(IEntity entity)
        {
            entity.AddInteractableTag();

            entity.AddInteractAction(new BaseAction<IEntity>(character =>
            {
                if (WeaponUseCase.AddClips(character, _clips))
                    gameObject.SetActive(false);
            }));
        }
    }
}