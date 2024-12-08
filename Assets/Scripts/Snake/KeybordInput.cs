using System;
using Modules;
using UnityEngine;
using Zenject;

namespace Snake
{
    public sealed class KeybordInput : ITickable
    {
        public event Action<SnakeDirection> DirectionChanged;

        private readonly KeybordMap _firstMap;
        private readonly KeybordMap _secondMap;

        public KeybordInput(KeybordMap firstMap, KeybordMap secondMap)
        {
            _firstMap = firstMap;
            _secondMap = secondMap;
        }

        public void Tick()
        {
            if (Input.GetKeyDown(_firstMap.Up) || Input.GetKeyDown(_secondMap.Up))
                DirectionChanged?.Invoke(SnakeDirection.UP);
            else if (Input.GetKeyDown(_firstMap.Down) || Input.GetKeyDown(_secondMap.Down))
                DirectionChanged?.Invoke(SnakeDirection.DOWN);
            else if (Input.GetKeyDown(_firstMap.Left) || Input.GetKeyDown(_secondMap.Left))
                DirectionChanged?.Invoke(SnakeDirection.LEFT);
            else if (Input.GetKeyDown(_firstMap.Right) || Input.GetKeyDown(_secondMap.Right))
                DirectionChanged?.Invoke(SnakeDirection.RIGHT);
        }

        [Serializable]
        public struct KeybordMap
        {
            public KeyCode Left;
            public KeyCode Right;
            public KeyCode Up;
            public KeyCode Down;
        }
    }
}