using System;
using UnityEngine;

namespace Game.Scripts.GameObjects.Core
{
    [Serializable]
    public sealed class TimerComponent
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

        public void Tick()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= _cooldownTime)
            {
                _isWorking = false;
            }
        }
    }
}