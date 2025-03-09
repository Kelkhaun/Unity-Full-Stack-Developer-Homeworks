using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Triggers
{
    [RequireComponent(typeof(Collider))]
    public sealed class EnemyTrigger : MonoBehaviour
    {
        [SerializeField] private SceneEntity[] _enemies;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            if (other.gameObject.TryGetEntity(out var entity))
            {
                Debug.Log(other.name);

                for (int i = 0; i < _enemies.Length; i++)
                    _enemies[i].SetTarget(entity);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetEntity(out var entity))
                for (int i = 0; i < _enemies.Length; i++)
                    _enemies[i].SetTarget(null);
        }
    }
}