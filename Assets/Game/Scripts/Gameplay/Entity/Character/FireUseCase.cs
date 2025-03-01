using Atomic.Entities;
using SampleGame;
using UnityEngine;

public static class FireUseCase
{
    public static void Fire(this IWeaponEntity entity)
    { 
        Quaternion spread = Quaternion.Euler(
            new Vector3(0f,
                Random.Range(-0.25f, 0.25f),
                0f));
        
        Object.Instantiate(entity.GetBulletPrefab(), 
            entity.GetFirePoint().transform.position, 
            entity.GetFirePoint().transform.rotation * spread);
    }
}

