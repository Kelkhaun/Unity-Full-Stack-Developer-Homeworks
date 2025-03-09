using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class AttackBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent _shootEvent;
        private IEvent _shootingRequest;
        private ExpressionBase<bool> _attackCondition;

        public void Init(in IEntity entity)
        {
            _shootEvent = entity.GetAttackEvent();
            _shootingRequest = entity.GetAttackRequest();
            _attackCondition = entity.GetAttackCondition();
        
            _shootingRequest.Subscribe(OnShootingRequest);
        }

        public void Dispose(in IEntity entity)
        {
            _shootingRequest.Unsubscribe(OnShootingRequest);
        }

        private void OnShootingRequest()
        {
            if (_attackCondition.Value)
            {
                _shootEvent.Invoke();
            }
        }
    }
}