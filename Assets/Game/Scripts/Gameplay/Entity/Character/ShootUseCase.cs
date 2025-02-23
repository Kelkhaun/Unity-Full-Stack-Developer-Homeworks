using Atomic.Entities;
using SampleGame;
using UnityEngine;

public static class ShootUseCase
{
    public static void Shoot(this IEntity entity)
    { 
        Object.Instantiate(entity.GetBulletPrefab(), 
            entity.GetShootPoint().transform.position, 
            entity.GetShootPoint().transform.rotation);
    }
}