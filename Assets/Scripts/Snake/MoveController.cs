using System;
using Modules;
using Zenject;

namespace Snake
{
    public sealed class MoveController : IInitializable, IDisposable
    {
        private readonly ISnake _snake;
        private readonly KeybordInput _keybordInput;

        public MoveController(KeybordInput keybordInput, ISnake snake)
        {
            _keybordInput = keybordInput;
            _snake = snake;
        }

        public void Initialize()
        {
            _keybordInput.DirectionChanged += _snake.Turn;
        }

        public void Dispose()
        {
            _keybordInput.DirectionChanged -= _snake.Turn;
        }
    }
}
