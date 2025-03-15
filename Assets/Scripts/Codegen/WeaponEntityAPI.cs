/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using Atomic.Elements;
using Atomic.Extensions;
using Game.Scripts.Types;
using Modules.Gameplay;

namespace SampleGame
{
	public static class WeaponEntityAPI
	{


		///Values
		public const int FireSpread = 2110708012; // ReactiveFloat
		public const int BulletCount = 64432308; // ReactiveInt
		public const int BulletPrefab = -918778767; // GameObject
		public const int FirePoint = 397255013; // Transform
		public const int ShootAction = 729771536; // BaseEvent
		public const int AnimationEventReceiver = 1837262450; // AnimationEventReceiver


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveFloat GetFireSpread(this IWeaponEntity obj) => obj.GetValue<ReactiveFloat>(FireSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireSpread(this IWeaponEntity obj, out ReactiveFloat value) => obj.TryGetValue(FireSpread, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireSpread(this IWeaponEntity obj, ReactiveFloat value) => obj.AddValue(FireSpread, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireSpread(this IWeaponEntity obj) => obj.HasValue(FireSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireSpread(this IWeaponEntity obj) => obj.DelValue(FireSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireSpread(this IWeaponEntity obj, ReactiveFloat value) => obj.SetValue(FireSpread, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetBulletCount(this IWeaponEntity obj) => obj.GetValue<ReactiveInt>(BulletCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletCount(this IWeaponEntity obj, out ReactiveInt value) => obj.TryGetValue(BulletCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletCount(this IWeaponEntity obj, ReactiveInt value) => obj.AddValue(BulletCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletCount(this IWeaponEntity obj) => obj.HasValue(BulletCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletCount(this IWeaponEntity obj) => obj.DelValue(BulletCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletCount(this IWeaponEntity obj, ReactiveInt value) => obj.SetValue(BulletCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetBulletPrefab(this IWeaponEntity obj) => obj.GetValue<GameObject>(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletPrefab(this IWeaponEntity obj, out GameObject value) => obj.TryGetValue(BulletPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletPrefab(this IWeaponEntity obj, GameObject value) => obj.AddValue(BulletPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletPrefab(this IWeaponEntity obj) => obj.HasValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletPrefab(this IWeaponEntity obj) => obj.DelValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletPrefab(this IWeaponEntity obj, GameObject value) => obj.SetValue(BulletPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetFirePoint(this IWeaponEntity obj) => obj.GetValue<Transform>(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFirePoint(this IWeaponEntity obj, out Transform value) => obj.TryGetValue(FirePoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFirePoint(this IWeaponEntity obj, Transform value) => obj.AddValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFirePoint(this IWeaponEntity obj) => obj.HasValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFirePoint(this IWeaponEntity obj) => obj.DelValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFirePoint(this IWeaponEntity obj, Transform value) => obj.SetValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BaseEvent GetShootAction(this IWeaponEntity obj) => obj.GetValue<BaseEvent>(ShootAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootAction(this IWeaponEntity obj, out BaseEvent value) => obj.TryGetValue(ShootAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootAction(this IWeaponEntity obj, BaseEvent value) => obj.AddValue(ShootAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootAction(this IWeaponEntity obj) => obj.HasValue(ShootAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootAction(this IWeaponEntity obj) => obj.DelValue(ShootAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootAction(this IWeaponEntity obj, BaseEvent value) => obj.SetValue(ShootAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AnimationEventReceiver GetAnimationEventReceiver(this IWeaponEntity obj) => obj.GetValue<AnimationEventReceiver>(AnimationEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimationEventReceiver(this IWeaponEntity obj, out AnimationEventReceiver value) => obj.TryGetValue(AnimationEventReceiver, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimationEventReceiver(this IWeaponEntity obj, AnimationEventReceiver value) => obj.AddValue(AnimationEventReceiver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimationEventReceiver(this IWeaponEntity obj) => obj.HasValue(AnimationEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimationEventReceiver(this IWeaponEntity obj) => obj.DelValue(AnimationEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimationEventReceiver(this IWeaponEntity obj, AnimationEventReceiver value) => obj.SetValue(AnimationEventReceiver, value);
    }
}
