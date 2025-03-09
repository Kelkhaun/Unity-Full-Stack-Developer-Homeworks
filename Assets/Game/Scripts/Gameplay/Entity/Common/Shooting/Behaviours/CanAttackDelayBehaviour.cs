using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class CanAttackDelayBehaviour : IEntityInit, IEntityDispose, IEntityUpdate
    {
        private ReactiveBool _canAttack;
        private Countdown _attackTimer;

        public void Init(in IEntity entity)
        {
            _canAttack = entity.GetCanAttack();
            _attackTimer = entity.GetAttackCooldown();
            _attackTimer.OnEnded += OnCountdownEnd;
        }

        public void Dispose(in IEntity entity)
        {
            _attackTimer.OnEnded -= OnCountdownEnd;
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            _attackTimer.Tick(deltaTime);
        }

        private void OnCountdownEnd()
        {
            _canAttack.Value = true;
        }
    }
}