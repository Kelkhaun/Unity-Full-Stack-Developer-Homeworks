using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class TimerComponent : MonoBehaviour
    {
        [SerializeField]
        private float _cooldownTime;

        private float _currentTime;
        private bool _isWorking;

        public bool IsOnCooldown => _isWorking;

        private void Update()
        {
            if (!_isWorking)
                return;

            Tick();
        }

        public void StartWork()
        {
            _isWorking = true;
            _currentTime = 0;
        }

        private void Tick()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= _cooldownTime)
            {
                _isWorking = false;
            }
        }
    }
}