using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public class CanHitSetBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private ReactiveBool _canHit;
        private ReactiveVariable<IEntity> _target;
        private Transform _transform;
        private ReactiveFloat _minDistance;

        public void Init(in IEntity entity)
        {
            _canHit = entity.GetCanHit();
            _target = entity.GetTarget();
            _transform = entity.GetGameObject().transform;
            _minDistance = entity.GetMinDistance();
        }

        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            if (_target.Value == null)
            {
                _canHit.Value = false;
                return;
            }

            var distance = Vector3.Distance(_transform.position, _target.Value.GetTransform().position);
            _canHit.Value = distance <= _minDistance.Value;
        }
    }
}