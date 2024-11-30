using System;
using Coin;
using Modules;
using Score;
using UI;
using UnityEngine;
using Zenject;

namespace Snake
{
    public sealed class SnakeCoinEater : IInitializable, IDisposable
    {
        private readonly ISnake _snake;
        private readonly CoinManager _manager;
        private readonly ScoreCounter _scoreCounter;

        public SnakeCoinEater(ISnake snake, CoinManager manager, ScoreCounter scoreCounter)
        {
            _scoreCounter = scoreCounter;
            _manager = manager;
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
            var coins = _manager.Coins;

            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].Position == _snake.HeadPosition)
                {
                    _scoreCounter.AdScore(coins[i].Score);
                    _snake.Expand(coins[i].Bones);
                    _manager.Despawn(coins[i]);
                    break;
                }
            }
        }
    }
}