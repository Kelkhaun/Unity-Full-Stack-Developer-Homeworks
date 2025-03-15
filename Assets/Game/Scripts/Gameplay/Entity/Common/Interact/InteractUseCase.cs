using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Interact
{
    public static class InteractUseCase
    {
        public static bool Interact(in IEntity source, in Collider collider)
        {
            return collider != null && collider.TryGetComponent(out IEntity entity) && Interact(source, entity);
        }

        public static bool Interact(in IEntity source, in IEntity target)
        {
            if (source == null)
                return false;

            if (target == null && !target.HasInteractableTag())
                return false;

            target.GetInteractEvent().Invoke(source);
            return true;
        }
    }
}