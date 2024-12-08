using System;
using Coin;
using Modules;
using Zenject;

namespace Infrasctrusture
{
    public sealed class DifficultyChanger : IInitializable, IDisposable
    {
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
            _difficulty.Next(out int _);
        }
    }                                
}