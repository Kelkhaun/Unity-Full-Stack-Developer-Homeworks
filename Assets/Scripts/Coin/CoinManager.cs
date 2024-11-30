using System;
using System.Collections.Generic;
using Modules;
using SnakeGame;
using Zenject;

namespace Coin
{
    public sealed class CoinManager : IInitializable, IDisposable
    {
        public event Action AllCoinsEated;

        private readonly IDifficulty _difficulty;
        private readonly CoinPool _pool;
        private readonly IWorldBounds _worldBounds;
        private List<Modules.Coin> _cashedCoins = new();

        public IReadOnlyList<Modules.Coin> Coins => _cashedCoins;

        public CoinManager(IDifficulty difficulty, CoinPool pool, IWorldBounds worldBounds)
        {
            _worldBounds = worldBounds;
            _pool = pool;
            _difficulty = difficulty;
        }

        public void Initialize()
        {
            _difficulty.OnStateChanged += OnDifficultyChanged;
        }

        public void Dispose()
        {
            _difficulty.OnStateChanged -= OnDifficultyChanged;
        }

        private void OnDifficultyChanged()
        {
            Spawn(_difficulty.Current);
        }

        private void Spawn(int coinCount)
        {
            for (int i = 0; i < coinCount; i++)
            {
                var coin = _pool.Spawn();
                _cashedCoins.Add(coin);
                coin.Position = _worldBounds.GetRandomPosition();
            }
        }

        public void Despawn(Modules.Coin coin)
        {
            _cashedCoins.Remove(coin);
            _pool.Despawn(coin);

            if(_cashedCoins.Count == 0)
                AllCoinsEated?.Invoke();
        }
    }
}