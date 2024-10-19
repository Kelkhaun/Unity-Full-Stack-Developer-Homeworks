using System;
using UnityEngine;

namespace Input
{
    public sealed class KeyboardInput : MonoBehaviour
    {
        public event Action<float> OnMove;
        public event Action OnFire;

        [SerializeField]
        private KeyboardMap _keyboardMap;

        private float _moveDirection;

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(_keyboardMap.Shoot))
                OnFire?.Invoke();

            if (UnityEngine.Input.GetKey(_keyboardMap.Left))
                _moveDirection = -1;
            else if (UnityEngine.Input.GetKey(_keyboardMap.Right))
                _moveDirection = 1;
            else
                _moveDirection = 0;

            OnMove?.Invoke(_moveDirection);
        }
    }
}