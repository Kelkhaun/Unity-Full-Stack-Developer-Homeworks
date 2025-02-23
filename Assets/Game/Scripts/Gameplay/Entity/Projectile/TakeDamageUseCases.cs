using Atomic.Entities;
using SampleGame;
using UnityEngine;

public static class TakeDamageUseCases
{
    public static bool TakeDamage(this Collision collision, int damage)
    {
        if (collision.TryGetEntity(out IEntity entity))
            return entity.TakeDamage(damage);
        
        return false;
    }

    public static bool TakeDamage(this IEntity entity, int damage)
    {
        if (entity.TryGetHealth(out var health) == false)
        return false;
        
        if(health.Value == 0)
            return false;
        
        health.Value = Mathf.Max(0, health.Value - damage);
        return true;
    }
}