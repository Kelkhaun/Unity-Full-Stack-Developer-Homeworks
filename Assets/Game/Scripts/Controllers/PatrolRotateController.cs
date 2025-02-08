using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public sealed class PatrolRotateController : MonoBehaviour
    {
        [SerializeField]
        private PatrolComponent _patrolComponent;

        [SerializeField]
        private RotateComponent _rotateComponent;

        private void OnEnable()
        {
            _patrolComponent.OnNextPoint += OnNextPoint;
        }

        private void OnDisable()
        {
            _patrolComponent.OnNextPoint -= OnNextPoint;
        }

        private void OnNextPoint()
        {
            float xDirection = _patrolComponent.Direction.x;
            _rotateComponent.Rotate(xDirection > 0
                ? RotateComponent.RotateDirection.Left
                : RotateComponent.RotateDirection.Right);
        }
    }
}