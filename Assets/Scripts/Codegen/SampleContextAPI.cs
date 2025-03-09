/**
* Code generation. Don't modify! 
**/

using Atomic.Contexts;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using Atomic.Contexts;
using Modules.Common;
using Atomic.Elements;

namespace SampleGame
{
	public static class SampleContextAPI
	{


		///Values
		public const int MoveJoystick = -1686028204; // Joystick
		public const int AimJoystick = -1668784795; // Joystick
		public const int Character = 294335127; // SceneEntity
		public const int BulletPool = 1915726678; // EntityPool
		public const int EntityWorld = 1757640864; // SceneEntityWorld
		public const int EnemyKillCount = -484439231; // ReactiveInt


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Joystick GetMoveJoystick(this IContext obj) => obj.GetValue<Joystick>(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveJoystick(this IContext obj, out Joystick value) => obj.TryGetValue(MoveJoystick, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveJoystick(this IContext obj, Joystick value) => obj.AddValue(MoveJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveJoystick(this IContext obj) => obj.HasValue(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveJoystick(this IContext obj) => obj.DelValue(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveJoystick(this IContext obj, Joystick value) => obj.SetValue(MoveJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Joystick GetAimJoystick(this IContext obj) => obj.GetValue<Joystick>(AimJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAimJoystick(this IContext obj, out Joystick value) => obj.TryGetValue(AimJoystick, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAimJoystick(this IContext obj, Joystick value) => obj.AddValue(AimJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAimJoystick(this IContext obj) => obj.HasValue(AimJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAimJoystick(this IContext obj) => obj.DelValue(AimJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAimJoystick(this IContext obj, Joystick value) => obj.SetValue(AimJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntity GetCharacter(this IContext obj) => obj.GetValue<SceneEntity>(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IContext obj, out SceneEntity value) => obj.TryGetValue(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCharacter(this IContext obj, SceneEntity value) => obj.AddValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IContext obj) => obj.HasValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IContext obj) => obj.DelValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IContext obj, SceneEntity value) => obj.SetValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static EntityPool GetBulletPool(this IContext obj) => obj.GetValue<EntityPool>(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletPool(this IContext obj, out EntityPool value) => obj.TryGetValue(BulletPool, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletPool(this IContext obj, EntityPool value) => obj.AddValue(BulletPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletPool(this IContext obj) => obj.HasValue(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletPool(this IContext obj) => obj.DelValue(BulletPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletPool(this IContext obj, EntityPool value) => obj.SetValue(BulletPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntityWorld GetEntityWorld(this IContext obj) => obj.GetValue<SceneEntityWorld>(EntityWorld);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEntityWorld(this IContext obj, out SceneEntityWorld value) => obj.TryGetValue(EntityWorld, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEntityWorld(this IContext obj, SceneEntityWorld value) => obj.AddValue(EntityWorld, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEntityWorld(this IContext obj) => obj.HasValue(EntityWorld);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEntityWorld(this IContext obj) => obj.DelValue(EntityWorld);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEntityWorld(this IContext obj, SceneEntityWorld value) => obj.SetValue(EntityWorld, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetEnemyKillCount(this IContext obj) => obj.GetValue<ReactiveInt>(EnemyKillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEnemyKillCount(this IContext obj, out ReactiveInt value) => obj.TryGetValue(EnemyKillCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEnemyKillCount(this IContext obj, ReactiveInt value) => obj.AddValue(EnemyKillCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEnemyKillCount(this IContext obj) => obj.HasValue(EnemyKillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEnemyKillCount(this IContext obj) => obj.DelValue(EnemyKillCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEnemyKillCount(this IContext obj, ReactiveInt value) => obj.SetValue(EnemyKillCount, value);
    }
}
