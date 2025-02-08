using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class RotateComponent : MonoBehaviour
    {
        [SerializeField]
        private GameObject _target;

        private RotateDirection _currentRotateDirection = RotateDirection.Right;

        public void Rotate(RotateDirection direction)
        {
            if (_currentRotateDirection == direction)
                return;

            _currentRotateDirection = direction;

            _target.transform.localScale = _currentRotateDirection == RotateDirection.Left
                ? new Vector3(-1, 1, 1)
                : new Vector3(1, 1, 1);
        }

        public enum RotateDirection
        {
            Left,
            Right,
        }
    }
}