using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.Content
{
    public sealed class Trampoline : MonoBehaviour
    {
        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private TriggerComponent _triggerComponent;

        private void OnEnable()
        {
            _triggerComponent.OnEnter += OnEnter;
        }
        
        private void OnDisable()
        {
            _triggerComponent.OnEnter += OnEnter;
        }

        private void OnEnter(GameObject triggeredGameObject)
        {
            _pushComponent.Push(triggeredGameObject);
        }
    }
}
