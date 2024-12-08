using System;
using Coin;
using Modules;
using UnityEngine;
using Zenject;

namespace Snake
{
    public sealed class SnakeCoinEater : IInitializable, IDisposable
    {
        private readonly ISnake _snake;
        private readonly CoinManager _coinManager;
        private readonly IScore _score;

        public SnakeCoinEater(ISnake snake, CoinManager coinManager, IScore score)
        {
            _score = score;
            _coinManager = coinManager;
            _snake = snake;
        }

        public void Initialize()
        {
            _snake.OnMoved += OnSnakeMoveChanged;
        }

        public void Dispose()
        {
            _snake.OnMoved -= OnSnakeMoveChanged;
        }

        private void OnSnakeMoveChanged(Vector2Int position)
        {
            if (_coinManager.TryTakeCoin(_snake.HeadPosition, out int score, out int bones))
            {
                _score.Add(score);
                _snake.Expand(bones);
            }
        }
    }
}