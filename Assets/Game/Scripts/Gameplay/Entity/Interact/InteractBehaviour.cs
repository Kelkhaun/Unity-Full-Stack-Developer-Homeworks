using Atomic.Entities;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;

public sealed class InteractBehaviour : IEntityInit, IEntityDispose
{
    private IEntity _entity;
    private TriggerEventReceiver _trigger;

    public void Init(in IEntity entity)
    {
        _entity = entity;
        _trigger = entity.GetTriggerEventReceiver();
        _trigger.OnEntered += OnTriggerEntered;
    }

    public void Dispose(in IEntity entity)
    {
        _trigger.OnEntered -= OnTriggerEntered;
    }

    private void OnTriggerEntered(Collider collider)
    {
        InteractUseCase.Interact(_entity, collider);
    }
}