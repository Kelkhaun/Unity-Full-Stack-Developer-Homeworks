using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.FirstAid
{
    public sealed class FirstAidInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _health = 3;

        [SerializeField]
        private BoxCollider _boxCollider;

        override public void Install(IEntity entity)
        {
            entity.AddInteractableTag();
            entity.AddAddedHealth(_health);
            entity.AddInteractableItemSuccess(new BaseEvent());
            entity.AddInteractEvent(new BaseEvent<IEntity>());
            entity.AddBehaviour<FirstAddBehaviour>();
            entity.AddBoxCollider(_boxCollider);

            entity.GetInteractableItemSuccess()
                .Subscribe(() => { _boxCollider.enabled = false; });
        }
    }

}