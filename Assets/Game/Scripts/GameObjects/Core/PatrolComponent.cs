using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    public sealed class PatrolComponent : MonoBehaviour
    {
        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        Transform[] _waypoints;

        [SerializeField]
        private Transform _target;

        private int _waypointIndex = 0;

        private void Update()
        {
            _moveComponent.MoveTowards(_waypoints[_waypointIndex]); 

            if (Vector3.Distance(_target.position, _waypoints[_waypointIndex].position) < 0.1f)
            {
                _waypointIndex = (_waypointIndex + 1) % _waypoints.Length;
            }
        }
    }
}