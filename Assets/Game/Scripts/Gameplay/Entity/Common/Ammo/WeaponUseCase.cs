using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.Shooting.UseCases;
using Game.Scripts.Types;
using SampleGame;

namespace Game.Scripts.Gameplay.Entity.Common.Ammo
{
    public static class WeaponUseCase
    {
        public static void Attack(this IWeaponEntity weapon, WeaponType weaponType)
        {
            if (weaponType == WeaponType.Range)
                weapon.Fire();
            else
                weapon.Hit();
        }

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
}