using System;
using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class PatrolComponent : MonoBehaviour
    {
        public event Action OnNextPoint;

        [SerializeField]
        Transform[] _waypoints;

        [SerializeField]
        private Transform _target;

        [SerializeField]
        private float _speed;

        private int _waypointIndex = 0;

        public Vector3 Direction => transform.position - _waypoints[_waypointIndex].position;

        private void Update()
        {
            if (_target.position == _waypoints[_waypointIndex].position)
            {
                _waypointIndex = (_waypointIndex + 1) % _waypoints.Length;
                OnNextPoint?.Invoke();
            }

            _target.position = Vector3.MoveTowards(_target.position,
                _waypoints[_waypointIndex].position,
                _speed * Time.deltaTime);
        }
    }
}