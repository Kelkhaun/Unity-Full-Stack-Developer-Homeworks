/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using Atomic.Elements;

namespace SampleGame
{
	public static class SampleEntityAPI
	{
		///Tags
		public const int Player = -1615495341;
		public const int Enemy = 979269037;
		public const int Resource = 1172805184;


		///Values
		public const int Health = -915003867; // int
		public const int MoveSpeed = 526065662; // ReactiveFloat
		public const int RotationSpeed = 1771316350; // ReactiveFloat
		public const int Transform = -180157682; // Transform
		public const int Direction = -1128574192; // ReactiveVector3
		public const int Rigidbody = -2101481708; // Rigidbody


		///Tag Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerTag(this IEntity obj) => obj.HasTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerTag(this IEntity obj) => obj.AddTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerTag(this IEntity obj) => obj.DelTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEnemyTag(this IEntity obj) => obj.HasTag(Enemy);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEnemyTag(this IEntity obj) => obj.AddTag(Enemy);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEnemyTag(this IEntity obj) => obj.DelTag(Enemy);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasResourceTag(this IEntity obj) => obj.HasTag(Resource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddResourceTag(this IEntity obj) => obj.AddTag(Resource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelResourceTag(this IEntity obj) => obj.DelTag(Resource);


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetHealth(this IEntity obj) => obj.GetValue<int>(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealth(this IEntity obj, out int value) => obj.TryGetValue(Health, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddHealth(this IEntity obj, int value) => obj.AddValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealth(this IEntity obj) => obj.HasValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealth(this IEntity obj) => obj.DelValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealth(this IEntity obj, int value) => obj.SetValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveFloat GetMoveSpeed(this IEntity obj) => obj.GetValue<ReactiveFloat>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.SetValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveFloat GetRotationSpeed(this IEntity obj) => obj.GetValue<ReactiveFloat>(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotationSpeed(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(RotationSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRotationSpeed(this IEntity obj, ReactiveFloat value) => obj.AddValue(RotationSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotationSpeed(this IEntity obj) => obj.HasValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotationSpeed(this IEntity obj) => obj.DelValue(RotationSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotationSpeed(this IEntity obj, ReactiveFloat value) => obj.SetValue(RotationSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetTransform(this IEntity obj) => obj.GetValue<Transform>(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTransform(this IEntity obj, out Transform value) => obj.TryGetValue(Transform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTransform(this IEntity obj, Transform value) => obj.AddValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTransform(this IEntity obj, Transform value) => obj.SetValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVector3 GetDirection(this IEntity obj) => obj.GetValue<ReactiveVector3>(Direction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDirection(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(Direction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDirection(this IEntity obj, ReactiveVector3 value) => obj.AddValue(Direction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDirection(this IEntity obj) => obj.HasValue(Direction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDirection(this IEntity obj) => obj.DelValue(Direction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDirection(this IEntity obj, ReactiveVector3 value) => obj.SetValue(Direction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rigidbody GetRigidbody(this IEntity obj) => obj.GetValue<Rigidbody>(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRigidbody(this IEntity obj, out Rigidbody value) => obj.TryGetValue(Rigidbody, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRigidbody(this IEntity obj, Rigidbody value) => obj.AddValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRigidbody(this IEntity obj) => obj.HasValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRigidbody(this IEntity obj) => obj.DelValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRigidbody(this IEntity obj, Rigidbody value) => obj.SetValue(Rigidbody, value);
    }
}
