using System;
using System.Collections.Generic;
using Game.Scripts.GameObjects.Core.Conditions;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class PushComponent : ConditionComponent
    {
        public Action OnPush;

        [SerializeField]
        private Transform _pushPoint;

        [SerializeField]
        private PushType _type;

        [SerializeField]
        private float _power;

        [SerializeField]
        private TimerComponent _timerComponent;

        [SerializeField]
        private Vector2 _checkboxSize;

        [SerializeField]
        private LayerMask _interactableLayer;

        [SerializeField]
        private Transform _overlapPoint;

        private void Awake()
        {
            AddCondition(() => !_timerComponent.IsOnCooldown);
        }

        private void Update()
        {
            _timerComponent.Tick();
        }

        public void Push(GameObject target)
        {
            if (target.gameObject.TryGetComponent(out Rigidbody2D rigidbody2D))
            {
                rigidbody2D.AddForce(
                    (_type == PushType.Horizontal ? _pushPoint.transform.forward : _pushPoint.transform.up)
                    * _power,
                    ForceMode2D.Impulse);
            }

            OnPush?.Invoke();
        }

        public void Push()
        {
            if (!CompositeCondition.IsTrue())
                return;

            _timerComponent.StartWork();

            List<GameObject> targets = GetTargets();

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

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(_overlapPoint.position, _checkboxSize);
        }

        private List<GameObject> GetTargets()
        {
            List<GameObject> targets = new List<GameObject>();

            var colliders = Physics2D.OverlapBoxAll(
                _overlapPoint.transform.position,
                _checkboxSize,
                0,
                _interactableLayer);

            foreach (var collider in colliders)
            {
                targets.Add(collider.gameObject);
            }

            return targets;
        }
    }


    public enum PushType
    {
        Horizontal,
        Vertical,
    }
}