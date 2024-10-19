using System.Collections.Generic;
using Character;
using Components;
using UnityEngine;

namespace Enemy
{
    public sealed class EnemyManager : MonoBehaviour
    {
        [SerializeField]
        private Transform[] _spawnPositions;

        [SerializeField]
        private Transform[] _attackPositions;

        [SerializeField]
        private EnemyPool _enemyPool;

        private readonly HashSet<Enemy> _cacheOfEnemies = new();

        public int ActiveEnemies => _cacheOfEnemies.Count;

        public void Spawn()
        {
            Enemy enemy = _enemyPool.Rent();
            _cacheOfEnemies.Add(enemy);
            enemy.GetComponent<HealthComponent>().OnHealthEmpty += OnEnemyDied;

            Transform spawnPosition = _spawnPositions.RandomPoint();
            enemy.transform.position = spawnPosition.position;

            Transform attackPosition = _attackPositions.RandomPoint();
            enemy.SetDestination(attackPosition.position);
        }

        private void OnEnemyDied(GameObject healthComponent)
        {
            Enemy enemy = healthComponent.GetComponent<Enemy>();

            healthComponent.GetComponent<HealthComponent>().OnHealthEmpty -= OnEnemyDied;
            _cacheOfEnemies.Remove(enemy);
            _enemyPool.Return(enemy);
        }
    }
}