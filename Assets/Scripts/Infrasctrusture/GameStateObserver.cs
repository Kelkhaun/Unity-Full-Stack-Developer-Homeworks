using System;
using Bounds;
using Modules;
using Zenject;

namespace Infrasctrusture
{
    public sealed class GameStateObserver : IInitializable, IDisposable
    {
        private readonly SnakeInBoundChecker _boundChecker;
        private readonly ISnake _snake;
        private readonly GameManager _gameManager;
        private readonly IDifficulty _difficulty;

        public GameStateObserver(SnakeInBoundChecker boundChecker, ISnake snake, GameManager gameManager,
            IDifficulty difficulty)
        {
            _difficulty = difficulty;
            _boundChecker = boundChecker;
            _snake = snake;
            _gameManager = gameManager;
        }

        public void Initialize()
        {
            _snake.OnSelfCollided += OnSnakeDeath;
            _boundChecker.SnakeOutOfBounce += OnSnakeDeath;
            _difficulty.OnStateChanged += OnStateChanged;
        }

        public void Dispose()
        {
            _snake.OnSelfCollided -= OnSnakeDeath;
            _boundChecker.SnakeOutOfBounce -= OnSnakeDeath;
        }

        private void OnStateChanged()
        {
            if((_difficulty.Current == _difficulty.Max))
            {
                OnGameComplete();
            }
        }

        private void OnGameComplete()
        {
            _gameManager.GameWon();
        }

        private void OnSnakeDeath()
        {
            _gameManager.GameLose();
        }
    }
}