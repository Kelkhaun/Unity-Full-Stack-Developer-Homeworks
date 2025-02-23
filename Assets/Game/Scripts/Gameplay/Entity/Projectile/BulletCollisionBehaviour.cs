using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using SampleGame;
using Unity.VisualScripting;
using UnityEngine;

namespace Game.Gameplay
{
    public class BulletCollisionBehaviour : IEntityInit, IEntityDispose
    {
        private ReactiveInt _damage;
        private IEvent _deathEvent;
        private CollisionEventReceiver _collisionEventReceiver;

        public void Init(in IEntity entity)
        {
            _damage = entity.GetDamage();
            _deathEvent = entity.GetDeathEvent();
            _collisionEventReceiver = entity.GetCollisionEventReceiver();

            _collisionEventReceiver.OnEntered += OnCollisionEnter;
        }

        public void Dispose(in IEntity entity)
        {
            _collisionEventReceiver.OnEntered -= OnCollisionEnter;
        }

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Bilo DA");
            collision.TakeDamage(_damage.Value);
            _deathEvent?.Invoke();
        }
    }
}