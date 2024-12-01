using System;
using Score;
using Snake;
using SnakeGame;
using Zenject;

namespace UI
{
    public sealed class ScoreViewObserver : IInitializable, IDisposable
    {
        private readonly SnakeCoinEater _snakeCoinEater;
        private readonly IGameUI _gameUI;

        private ScoreCounter _scoreCounter;

        public ScoreViewObserver(ScoreCounter scoreCounter, IGameUI gameUI)
        {
            _scoreCounter = scoreCounter;
            _gameUI = gameUI;
        }

        public void Initialize()
        {
            _scoreCounter.OnScoreChanged += OnScoreChanged;
            OnScoreChanged();
        }

        public void Dispose()
        {
            _scoreCounter.OnScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged()
        {
            _gameUI.SetScore(_scoreCounter.Score.ToString());
        }
    }
}