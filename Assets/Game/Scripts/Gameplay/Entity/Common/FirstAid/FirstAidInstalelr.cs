using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.FirstAid
{
    public sealed class FirstAidInstalelr : SceneEntityInstaller
    {
        [SerializeField]
        private int _health = 3;

        override public void Install(IEntity entity)
        {
            entity.AddInteractableTag();

            entity.AddInteractAction(new BaseAction<IEntity>(character =>
            {
                if (HealthUseCase.AddHealth(character, _health))
                    gameObject.SetActive(false);
            }));
        }
    }

}