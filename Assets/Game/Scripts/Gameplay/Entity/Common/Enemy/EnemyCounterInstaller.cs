using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using SampleGame;
using UnityEngine;

public class EnemyCounterInstaller : SceneContextInstaller
{
    [SerializeField] private SceneEntityWorld _sceneEntityWorld;
    
    public override void Install(IContext context)
    {
        context.AddEntityWorld(_sceneEntityWorld);
        context.AddEnemyKillCount(new ReactiveInt());
        context.AddController<EnemyCounterController>();
    }
}
