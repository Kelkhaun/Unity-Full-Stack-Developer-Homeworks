using System;
using Modules;
using UnityEngine;
using Zenject;

namespace Input
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
            if (UnityEngine.Input.GetKeyDown(_firstMap.Up) || UnityEngine.Input.GetKeyDown(_secondMap.Up))
                DirectionChanged?.Invoke(SnakeDirection.UP);
            else if (UnityEngine.Input.GetKeyDown(_firstMap.Down) || UnityEngine.Input.GetKeyDown(_secondMap.Down))
                DirectionChanged?.Invoke(SnakeDirection.DOWN);
            else if (UnityEngine.Input.GetKeyDown(_firstMap.Left) || UnityEngine.Input.GetKeyDown(_secondMap.Left))
                DirectionChanged?.Invoke(SnakeDirection.LEFT);
            else if (UnityEngine.Input.GetKeyDown(_firstMap.Right) || UnityEngine.Input.GetKeyDown(_secondMap.Right))
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