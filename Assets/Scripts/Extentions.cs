using Character;
using Components;
using UnityEngine;

public static class Extentions
{
    public static Transform RandomPoint(this Transform[] points)
    {
        int index = Random.Range(0, points.Length);
        return points[index];
    }

    public static void DealDamage(this GameObject other, int damage, bool isPlayer)
    {
        if (damage <= 0)
            return;

        if (other.TryGetComponent(out TeamComponent team))
        {
            if (team.IsPlayer == isPlayer)
            {
                return;
            }
        }

        if (other.TryGetComponent(out HealthComponent target))
        {
            target.GetHit(damage);
        }
    }
}