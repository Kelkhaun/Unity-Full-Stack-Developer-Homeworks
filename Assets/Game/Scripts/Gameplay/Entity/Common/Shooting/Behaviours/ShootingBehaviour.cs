using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class ShootingBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent _shootEvent;
        private IEvent _shootingRequest;
        private ExpressionBase<bool> _shootingCondition;

        public void Init(in IEntity entity)
        {
            _shootEvent = entity.GetShootEvent();
            _shootingRequest = entity.GetShootingRequest();
            _shootingCondition = entity.GetShootingCondition();
        
            _shootingRequest.Subscribe(OnShootingRequest);
        }

        public void Dispose(in IEntity entity)
        {
            _shootingRequest.Unsubscribe(OnShootingRequest);
        }

        private void OnShootingRequest()
        {
            if (_shootingCondition.Value)
            {
                _shootEvent.Invoke();
            }
        }
    }
}