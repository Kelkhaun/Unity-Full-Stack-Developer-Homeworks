using System;
using Bounds;
using Difficulty;
using Modules;
using Zenject;

namespace Infrasctrusture
{
    public sealed class GameStateObserver : IInitializable, IDisposable
    {
        private readonly SnakeInBoundChecker _boundChecker;
        private readonly ISnake _snake;
        private readonly GameManager _gameManager;
        private readonly DifficultyChanger _difficultyChanger;

        public GameStateObserver(SnakeInBoundChecker boundChecker, ISnake snake, GameManager gameManager,
            DifficultyChanger difficultyChanger)
        {
            _difficultyChanger = difficultyChanger;
            _boundChecker = boundChecker;
            _snake = snake;
            _gameManager = gameManager;
        }

        public void Initialize()
        {
            _snake.OnSelfCollided += OnSnakeDeath;
            _boundChecker.SnakeOutOfBounce += OnSnakeDeath;
            _difficultyChanger.OnGameComplete += OnGameComplete;
        }

        public void Dispose()
        {
            _snake.OnSelfCollided -= OnSnakeDeath;
            _boundChecker.SnakeOutOfBounce -= OnSnakeDeath;
            _difficultyChanger.OnGameComplete -= OnGameComplete;
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