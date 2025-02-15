using System;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameContext
{
    public sealed class CharacterMoveController : MonoBehaviour
    {
        private string HORIZONTAL_AXIS = "Horizontal";

        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        private RotateComponent _rotateComponent;

        private Vector2 _direction;

        private void Update()
        {
            _direction.x = Input.GetAxisRaw(HORIZONTAL_AXIS);

            _moveComponent.Move(_direction);

            if (Mathf.Abs(_direction.x - 1) < float.Epsilon)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Right);

            if (Mathf.Abs(_direction.x + 1) < float.Epsilon)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Left);
        }
    }
}