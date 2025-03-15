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
                entity.GetDeathEvent().Subscribe(RemoveTargetFromEnemies);
                SetTargetToEnemies(entity);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetEntity(out IEntity entity))
            {
                RemoveTargetFromEnemies();
                entity.GetDeathEvent().Unsubscribe(RemoveTargetFromEnemies);
            }
        }

        private void SetTargetToEnemies(IEntity entity)
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                if (_enemies[i] != null)
                    _enemies[i].GetTarget().Value = entity;
            }
        }

        private void RemoveTargetFromEnemies()
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                if (_enemies[i] != null)
                    _enemies[i].GetTarget().Value = null;
            }
        }
    }
}