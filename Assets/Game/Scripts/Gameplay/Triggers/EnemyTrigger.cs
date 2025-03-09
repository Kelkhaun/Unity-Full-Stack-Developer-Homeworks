using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Triggers
{
    [RequireComponent(typeof(Collider))]
    public sealed class EnemyTrigger : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity[] _enemies;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetEntity(out IEntity entity))
            {
                entity.GetDeathEvent().Subscribe(Unsubscribe);
                Subscribe(entity);
            }
        }

        private void Subscribe(IEntity entity)
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                _enemies[i].GetTarget().Value = entity;
            }
        }

        private void Unsubscribe()
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                _enemies[i].GetTarget().Value = null;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetComponent(out SceneEntity entity))
            {
                Unsubscribe();
                entity.GetDeathEvent().Unsubscribe(Unsubscribe);
            }
        }
    }
}
