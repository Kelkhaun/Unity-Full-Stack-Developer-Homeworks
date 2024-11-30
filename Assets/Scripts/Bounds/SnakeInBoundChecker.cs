using System;
using Modules;
using SnakeGame;
using UnityEngine;
using Zenject;

namespace Bounds
{
    public sealed class SnakeInBoundChecker : IInitializable, IDisposable
    {
        public event Action SnakeOutOfBounce;

        private readonly IWorldBounds _bounds;
        private readonly ISnake _snake;

        public SnakeInBoundChecker(IWorldBounds bounds, ISnake snake)
        {
            _bounds = bounds;
            _snake = snake;
        }

        public void Initialize()
        {
            _snake.OnMoved += OnSnakeMoved;
        }

        public void Dispose()
        {
            _snake.OnMoved -= OnSnakeMoved;
        }

        private void OnSnakeMoved(Vector2Int position)
        {
            if (_bounds.IsInBounds(position))
                return;

            SnakeOutOfBounce?.Invoke();
        }
    }
}
