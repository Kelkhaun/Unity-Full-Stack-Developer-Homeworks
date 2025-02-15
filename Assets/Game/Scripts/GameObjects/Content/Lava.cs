using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public sealed class Lava : MonoBehaviour
    {
        [SerializeField]
        private DestroyerComponent _destroyerComponent;

        [SerializeField]
        private TriggerComponent triggerComponent;

        private void OnEnable()
        {
            triggerComponent.OnEnter += OnLavaTouched;
        }

        private void OnDisable()
        {
            triggerComponent.OnEnter -= OnLavaTouched;
        }

        private void OnLavaTouched(GameObject collidedObject)
        {
            _destroyerComponent.DestroyGameObject(collidedObject);
        }
    }
}