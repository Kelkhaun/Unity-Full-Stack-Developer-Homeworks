using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Ammo;
using SampleGame;
using UnityEngine;

public sealed class AmmoPickUpBehaviour : IEntityInit, IEntityDispose
{
    private BaseEvent<IEntity> _interactAction;
    private ReactiveInt _clips;
    private BaseEvent _interactableItemSuccessEvent;

    public void Init(in IEntity entity)
    {
        _interactAction = entity.GetInteractEvent();
        _interactableItemSuccessEvent = entity.GetInteractableItemSuccess();
        _clips = entity.GetClips();

        _interactAction.Subscribe(OnInteract);
    }

    public void Dispose(in IEntity entity)
    {
        _interactAction.Unsubscribe(OnInteract);
    }

    private void OnInteract(IEntity entity)
    {
        if (WeaponUseCase.AddClips(entity, _clips.Value)) 
            _interactableItemSuccessEvent.Invoke();
    }
}