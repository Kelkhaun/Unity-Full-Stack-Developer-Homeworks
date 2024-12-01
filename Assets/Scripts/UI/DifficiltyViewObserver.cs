using System;
using Modules;
using SnakeGame;
using Zenject;

namespace UI
{
    public sealed class DifficiltyViewObserver : IInitializable, IDisposable
    {
        private readonly IDifficulty _difficulty;
        private readonly IGameUI _gameUI;

        public DifficiltyViewObserver(IDifficulty difficulty, IGameUI gameUI)
        {
            _gameUI = gameUI;
            _difficulty = difficulty;
        }

        public void Initialize()
        {
            _difficulty.OnStateChanged += OnStateChanged;
            OnStateChanged();
        }

        public void Dispose()
        {
            _difficulty.OnStateChanged -= OnStateChanged;
        }

        private void OnStateChanged()
        {
            _gameUI.SetDifficulty(_difficulty.Current, _difficulty.Max);
        }
    }
}