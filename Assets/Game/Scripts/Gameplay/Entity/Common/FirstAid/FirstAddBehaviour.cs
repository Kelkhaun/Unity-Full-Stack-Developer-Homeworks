using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.FirstAid;
using SampleGame;
using UnityEngine;

public sealed class FirstAddBehaviour : IEntityInit, IEntityDispose
{
    private BaseEvent<IEntity> _interactAction;
    private ReactiveInt _health;
    private BaseEvent _interactableSuccessEvent;

    public void Init(in IEntity entity)
    {
        _interactAction = entity.GetInteractEvent();
        _interactableSuccessEvent = entity.GetInteractableItemSuccess();
        _health = entity.GetAddedHealth();

        _interactAction.Subscribe(OnInteract);
    }

    public void Dispose(in IEntity entity)
    {
        _interactAction.Unsubscribe(OnInteract);
    }

    private void OnInteract(IEntity entity)
    {
        if (HealthUseCase.AddHealth(entity, _health.Value)) 
            _interactableSuccessEvent.Invoke();
    }
}