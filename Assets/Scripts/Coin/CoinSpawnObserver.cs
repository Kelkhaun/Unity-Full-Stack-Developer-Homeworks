using System;
using Modules;
using Zenject;

namespace Coin
{
    public sealed class CoinSpawnObserver : IInitializable, IDisposable
    {
        private readonly CoinManager _coinManager;
        private readonly IDifficulty _difficulty;

        public CoinSpawnObserver(CoinManager coinManager, IDifficulty difficulty)
        {
            _difficulty = difficulty;
            _coinManager = coinManager;
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
            _coinManager.Spawn(_difficulty.Current);
        }
    }
}