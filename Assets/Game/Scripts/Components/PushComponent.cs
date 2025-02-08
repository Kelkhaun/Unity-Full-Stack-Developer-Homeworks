using Game.Scripts.Components.Conditions;
using Game.Scripts.Components.Finders;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Components
{
    public sealed class PushComponent : ConditionComponent
    {
        public UnityEvent OnPush;

        [SerializeField]
        private FindTargetComponent _findTargetComponent;

        [SerializeField]
        private Transform _pushPoint;

        [SerializeField]
        private PushType _type;

        [SerializeField]
        private float _power;

        public void Push()
        {
            if (!CompositeCondition.IsTrue())
                return;

            var targets = _findTargetComponent.GetTargets();

            foreach (var target in targets)
            {
                if (target.TryGetComponent(out Rigidbody2D rigidbody2D))
                {
                    rigidbody2D.AddForce(
                        (_type == PushType.Horizontal ? _pushPoint.transform.forward : _pushPoint.transform.up)
                        * _power,
                        ForceMode2D.Impulse);
                }
            }

            OnPush?.Invoke();
        }
    }


    public enum PushType
    {
        Horizontal,
        Vertical,
    }
}