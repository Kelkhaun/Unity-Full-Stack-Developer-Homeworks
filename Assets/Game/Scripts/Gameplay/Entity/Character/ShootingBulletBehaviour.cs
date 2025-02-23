using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

public class ShootingBulletBehaviour : IEntityInit, IEntityDispose
{
    private IEvent _shootEvent;
    private IEntity _entity;

    public void Init(in IEntity entity)
    {
        _entity = entity;
        _shootEvent = entity.GetShootEvent();
        _shootEvent.Subscribe(Shoot);
    }

    public void Dispose(in IEntity entity)
    {
        _shootEvent.Unsubscribe(Shoot);
    }

    private void Shoot()
    {
        _entity.Shoot();
    }
}