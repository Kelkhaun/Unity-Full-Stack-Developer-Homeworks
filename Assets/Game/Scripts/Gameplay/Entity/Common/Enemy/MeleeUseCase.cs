using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Projectile;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

public static class MeleeUseCase
{
    public static bool Hit(this IWeaponEntity weapon)
    {
        var firePoint = weapon.GetFirePoint();

        var colliders = Physics.OverlapSphere(firePoint.position, 3f);

        foreach (var collider in colliders)
        {
            if (collider.TryGetEntity(out IEntity entity))
                weapon.Hit(entity);
        }

        return false;
    }

    public static void Hit(this IWeaponEntity weapon, IEntity entity)
    {
        entity.TakeDamage(weapon.GetDamage().Value);
    }
}
   