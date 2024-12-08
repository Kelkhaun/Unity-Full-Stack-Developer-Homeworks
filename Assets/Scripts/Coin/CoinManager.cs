using System;
using System.Collections.Generic;
using SnakeGame;
using UnityEngine;

namespace Coin
{
    public sealed class CoinManager
    {
        public event Action AllCoinsEated;

        private readonly CoinPool _pool;
        private readonly IWorldBounds _worldBounds;
        private readonly List<Modules.Coin> _cashedCoins = new();
        private readonly CoinSpawnObserver _coinSpawnObserver;

        public CoinManager(CoinPool pool, IWorldBounds worldBounds)
        {
            _worldBounds = worldBounds;
            _pool = pool;
        }

        public void Spawn(int coinCount)
        {
            for (int i = 0; i < coinCount; i++)
            {
                var coin = _pool.Spawn();
                _cashedCoins.Add(coin);
                coin.Position = _worldBounds.GetRandomPosition();
            }
        }

        private void Despawn(Modules.Coin coin)
        {
            _cashedCoins.Remove(coin);
            _pool.Despawn(coin);

            if (_cashedCoins.Count == 0)
                AllCoinsEated?.Invoke();
        }

        public bool TryTakeCoin(Vector2Int snakeHeadPosition, out int score, out int bones)
        {
            for (int i = 0; i < _cashedCoins.Count; i++)
            {
                if (_cashedCoins[i].Position == snakeHeadPosition)
                {
                    score = _cashedCoins[i].Score;
                    bones = _cashedCoins[i].Bones;
                    Despawn(_cashedCoins[i]);
                    return true;
                }
            }

            score = default;
            bones = default;
            return false;
        }
    }
}