using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Projectile
{
    public sealed class ProjectileVisualInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private TrailView _trailView;
        
        public override void Install(IEntity entity)
        {
            entity.WhenEnable(() => _trailView.Show());
            entity.WhenDisable(() => _trailView.Hide());
        }
    }
}