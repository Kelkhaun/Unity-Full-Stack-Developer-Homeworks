using System;
using Modules;
using Snake;
using SnakeGame;
using Zenject;

namespace UI
{
    public sealed class ScoreViewObserver : IInitializable, IDisposable
    {
        private readonly SnakeCoinEater _snakeCoinEater;
        private readonly IGameUI _gameUI;

        private IScore _score;

        public ScoreViewObserver(IScore score, IGameUI gameUI)
        {
            _score = score;
            _gameUI = gameUI;
        }

        public void Initialize()
        {
            _score.OnStateChanged += OnStateChanged;
            OnStateChanged(_score.Current);
        }

        public void Dispose()
        {
            _score.OnStateChanged -= OnStateChanged;
        }

        private void OnStateChanged(int score)
        {
            _gameUI.SetScore(score.ToString());
        }
    }
}