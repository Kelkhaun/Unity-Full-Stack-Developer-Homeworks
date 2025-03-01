using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

public class DeathBehaviour : IEntityInit, IEntityDisable, IEntityEnable
{
    private IEvent _deathEvent;
    private ReactiveInt _health;

    public void Init(in IEntity entity)
    {
        _health = entity.GetHealth();
        _deathEvent = entity.GetDeathEvent();
    }

    public void Enable(in IEntity entity)
    {
        _health.Subscribe(OnHealthChanged);
    }

    public void Disable(in IEntity entity)
    {
        _health.Unsubscribe(OnHealthChanged);
    }

    private void OnHealthChanged(int healthValue)
    {
        if (healthValue <= 0)
            _deathEvent?.Invoke();
    }
}