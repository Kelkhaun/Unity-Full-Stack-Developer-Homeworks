using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;

namespace Game.Gameplay
{
    public sealed class ProjectileCoreInstaller : SceneEntityInstaller
    {
        [SerializeField] private Timer _lifeTimer;
        [SerializeReference] private IEntityActionAsset[] _finishActions;
        [SerializeField] private ReactiveFloat _moveSpeed;
        [SerializeField] private ReactiveVector3 _moveDirection;
        [SerializeField] private ReactiveInt _damage;
        [SerializeField] private CollisionEventReceiver _collisionReciver;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeReference] private IEntityActionAsset[] _deathActions;

        public override void Install(IEntity entity)
        {
            _lifeTimer.SubscribeOnCompleteBy(_finishActions, entity);
            entity.AddLifeTimeCountdown(_lifeTimer);
            entity.WhenInit(() => _lifeTimer.Start());
            entity.WhenUpdate(_lifeTimer.Tick);
            entity.AddGameObject(gameObject);
            BaseEvent deathEvent = new BaseEvent();
            deathEvent.SubscribeAllBy(_deathActions, entity);
            entity.AddDeathEvent(deathEvent);

            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddTransform(transform);
            entity.AddDamage(_damage);
            entity.AddCollisionEventReceiver(_collisionReciver);
            entity.AddRigidbody(_rigidbody);
                
            entity.AddBehaviour<BulletMoveDirectionBehavior>();
            entity.AddBehaviour<MovementBehaviour>();
            entity.AddBehaviour<BulletCollisionBehaviour>();
        }
    }
}