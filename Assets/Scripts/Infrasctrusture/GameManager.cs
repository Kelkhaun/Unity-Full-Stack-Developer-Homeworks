using SnakeGame;
using UnityEngine;

namespace Infrasctrusture
{
    public sealed class GameManager
    {
        private readonly IGameUI _gameUI;

        public GameManager(IGameUI ui)
        {
            _gameUI = ui;
        }

        public void GameWon()
        {
            _gameUI.GameOver(true);
            Time.timeScale = 0f;
        }

        public void GameLose()
        {
            _gameUI.GameOver(false);
            Time.timeScale = 0f;
        }
    }
}
