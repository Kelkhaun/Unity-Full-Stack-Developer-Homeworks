using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.Behaviours
{
    public class CanShootDelayBehaviour : IEntityInit, IEntityDispose, IEntityUpdate
    {
        private ReactiveBool _canShoot;
        private Countdown _shootTimer;


        public void Init(in IEntity entity)
        {
            _canShoot = entity.GetCanShoot();
            _shootTimer = entity.GetShootTimer();
            _shootTimer.OnEnded += OnCountdownEnd;
        }

        public void Dispose(in IEntity entity)
        {
            _shootTimer.OnEnded -= OnCountdownEnd;
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            _shootTimer.Tick(deltaTime);
        }

        private void OnCountdownEnd()
        {
            _canShoot.Value = true;
        }
    }
}