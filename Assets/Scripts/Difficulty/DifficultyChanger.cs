using System;
using Coin;
using Modules;
using Zenject;

namespace Difficulty
{
    public sealed class DifficultyChanger : IInitializable, IDisposable
    {
        public event Action OnGameComplete;

        private readonly CoinManager _coinManager;
        private readonly IDifficulty _difficulty;
    
        public DifficultyChanger(CoinManager coinManager, IDifficulty difficulty)
        {
            _coinManager = coinManager;
            _difficulty = difficulty;
        }

        public void Initialize()
        {
            _coinManager.AllCoinsEated += OnAllCoinsEated;
            _difficulty.Next(out int difficulty);
        }

        public void Dispose()
        {
            _coinManager.AllCoinsEated += OnAllCoinsEated;
        }

        private void OnAllCoinsEated()
        {
            if (_difficulty.Next(out int difficulty))
            {
                return;
            }

            OnGameComplete?.Invoke();
        }
    }
}