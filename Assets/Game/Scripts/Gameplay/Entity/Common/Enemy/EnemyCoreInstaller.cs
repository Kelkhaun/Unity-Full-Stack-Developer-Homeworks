using Atomic.Entities;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Enemy
{
    public sealed class EnemyCoreInstaller : SceneEntityInstaller
    {
        public override void Install(IEntity entity)
        {
            entity.AddEnemyTag();
            entity.AddGameObject(this.gameObject);
            entity.AddTarget(null);
        }
    }
}