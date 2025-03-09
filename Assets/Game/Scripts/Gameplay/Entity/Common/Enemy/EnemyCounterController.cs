using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using SampleGame;

public class EnemyCounterController : IContextInit, IEntityDispose
{
    private SceneEntityWorld _entityWorld;
    private IReadOnlyList<IEntity> _enemies;
    private ReactiveInt _enemyKillCount;
    
    public void Init(IContext context)
    {
        _enemyKillCount = context.GetEnemyKillCount();
        _entityWorld = context.GetEntityWorld();
        _enemies =  _entityWorld.GetAllWithTag(979269037);

        for (int i = 0; i < _enemies.Count; i++)
            _enemies[i].GetDeathEvent().Subscribe(OnEnemyDeath);
    }

    public void Dispose(in IEntity entity)
    {
        for (int i = 0; i < _enemies.Count; i++)
            _enemies[i].GetDeathEvent().Unsubscribe(OnEnemyDeath);
    }

    private void OnEnemyDeath()
    {
        _enemyKillCount.Value++;
    }
}