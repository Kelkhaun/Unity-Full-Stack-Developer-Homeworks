using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Controllers
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

            if (_direction.x == 1)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Right);

            if (_direction.x == -1)
                _rotateComponent.Rotate(RotateComponent.RotateDirection.Left);
        }
    }
}