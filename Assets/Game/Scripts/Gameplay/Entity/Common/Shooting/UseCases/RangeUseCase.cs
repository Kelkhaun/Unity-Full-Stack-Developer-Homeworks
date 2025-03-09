using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

namespace Game.Scripts.Gameplay.Entity.Common.Shooting.UseCases
{
    public static class RangeUseCase
    {
        public static void Fire(this IWeaponEntity entity)
        { 
            Quaternion spread = Quaternion.Euler(
                new Vector3(0f,
                    Random.Range(-entity.GetFireSpread().Value, entity.GetFireSpread().Value),
                    0f));
        
            Object.Instantiate(entity.GetBulletPrefab(), 
                entity.GetFirePoint().transform.position, 
                entity.GetFirePoint().transform.rotation * spread);
        }
    }
}

