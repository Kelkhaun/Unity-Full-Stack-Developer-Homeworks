using Bullets;
using Character;
using Components;
using UnityEngine;

namespace Enemy
{
    public sealed class Enemy : MonoBehaviour
    {
        [SerializeField]
        private TeamComponent _teamComponent;

        [SerializeField]
        private MoveComponent _moveComponent;

        [SerializeField]
        private FireComponent _fireComponent;

        [SerializeField]
        private float _countdown;

        [SerializeField]
        private BulletConfig _config;

        private Player _target;
        private Vector2 _destination;
        private float _currentTime;
        private bool _isPointReached;
        private float _offset =  0.25f;

        public void Reset()
        {
            _currentTime = _countdown;
        }

        public void Construct(Player player, BulletManager bulletSystem)
        {
            _target = player;
            _fireComponent.Construct(bulletSystem);
        }

        public void SetDestination(Vector2 endPoint)
        {
            _destination = endPoint;
            _isPointReached = false;
        }

        private void FixedUpdate()
        {
            if (_isPointReached)
            {
                _currentTime -= Time.fixedDeltaTime;

                if (_currentTime <= 0)
                {
                    Vector2 startPosition = _fireComponent.FirePoint.position;
                    Vector2 vector = (Vector2) _target.transform.position - startPosition;
                    Vector2 direction = vector.normalized;
                    _fireComponent.Shoot(direction);

                    _currentTime += _countdown;
                }
            }
            else
            {
                Vector2 vector = _destination - (Vector2) transform.position;

                if (vector.magnitude <= _offset)
                {
                    _isPointReached = true;
                    return;
                }

                Vector2 direction = vector.normalized * Time.fixedDeltaTime;
                _moveComponent.Move(direction);
            }
        }
    }
}