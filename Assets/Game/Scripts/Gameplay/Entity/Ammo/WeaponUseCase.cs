using Atomic.Entities;
using SampleGame;

public static class WeaponUseCase
{
    public static bool AddClips(IEntity character, int clips)
    {
        if (character == null)
            return false;

        if (character.GetWeapon() == null)
            return false;

        character.GetWeapon().AddClips(clips);
        return true;
    }
    
    public static void AddClips(this IWeaponEntity entity, int clips)
    {
        entity.GetBulletCount().Value += clips;
    }
}