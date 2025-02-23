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
		public const int Transform = -180157682; // Transform
		public const int Rigidbody = -2101481708; // Rigidbody
		public const int MoveDirection = -721923052; // ReactiveVector3
		public const int MoveSpeed = 526065662; // ReactiveFloat
		public const int RotateDirection = -1044844011; // ReactiveVector3
		public const int RotationSpeed = 1771316350; // ReactiveFloat
		public const int ShootEvent = -1898355213; // IEvent
		public const int ShootingRequest = -1070173053; // IEvent
		public const int ShootingOverRequest = -65613924; // IEvent
		public const int BulletPrefab = -918778767; // GameObject
		public const int ShootPoint = 47357040; // Transform
		public const int ShootingCondition = 1909327147; // AndExpression
		public const int CanShoot = -1431824453; // ReactiveBool
		public const int ShootTimer = -542658226; // Countdown


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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVector3 GetMoveDirection(this IEntity obj) => obj.GetValue<ReactiveVector3>(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDirection(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(MoveDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.AddValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.SetValue(MoveDirection, value);

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
		public static ReactiveVector3 GetRotateDirection(this IEntity obj) => obj.GetValue<ReactiveVector3>(RotateDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotateDirection(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(RotateDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRotateDirection(this IEntity obj, ReactiveVector3 value) => obj.AddValue(RotateDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotateDirection(this IEntity obj) => obj.HasValue(RotateDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotateDirection(this IEntity obj) => obj.DelValue(RotateDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotateDirection(this IEntity obj, ReactiveVector3 value) => obj.SetValue(RotateDirection, value);

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
		public static IEvent GetShootEvent(this IEntity obj) => obj.GetValue<IEvent>(ShootEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootEvent(this IEntity obj, IEvent value) => obj.AddValue(ShootEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootEvent(this IEntity obj) => obj.HasValue(ShootEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootEvent(this IEntity obj) => obj.DelValue(ShootEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootEvent(this IEntity obj, IEvent value) => obj.SetValue(ShootEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetShootingRequest(this IEntity obj) => obj.GetValue<IEvent>(ShootingRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootingRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootingRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootingRequest(this IEntity obj, IEvent value) => obj.AddValue(ShootingRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootingRequest(this IEntity obj) => obj.HasValue(ShootingRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootingRequest(this IEntity obj) => obj.DelValue(ShootingRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootingRequest(this IEntity obj, IEvent value) => obj.SetValue(ShootingRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetShootingOverRequest(this IEntity obj) => obj.GetValue<IEvent>(ShootingOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootingOverRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootingOverRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootingOverRequest(this IEntity obj, IEvent value) => obj.AddValue(ShootingOverRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootingOverRequest(this IEntity obj) => obj.HasValue(ShootingOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootingOverRequest(this IEntity obj) => obj.DelValue(ShootingOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootingOverRequest(this IEntity obj, IEvent value) => obj.SetValue(ShootingOverRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetBulletPrefab(this IEntity obj) => obj.GetValue<GameObject>(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletPrefab(this IEntity obj, out GameObject value) => obj.TryGetValue(BulletPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletPrefab(this IEntity obj, GameObject value) => obj.AddValue(BulletPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletPrefab(this IEntity obj) => obj.HasValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletPrefab(this IEntity obj) => obj.DelValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletPrefab(this IEntity obj, GameObject value) => obj.SetValue(BulletPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetShootPoint(this IEntity obj) => obj.GetValue<Transform>(ShootPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootPoint(this IEntity obj, out Transform value) => obj.TryGetValue(ShootPoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootPoint(this IEntity obj, Transform value) => obj.AddValue(ShootPoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootPoint(this IEntity obj) => obj.HasValue(ShootPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootPoint(this IEntity obj) => obj.DelValue(ShootPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootPoint(this IEntity obj, Transform value) => obj.SetValue(ShootPoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AndExpression GetShootingCondition(this IEntity obj) => obj.GetValue<AndExpression>(ShootingCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootingCondition(this IEntity obj, out AndExpression value) => obj.TryGetValue(ShootingCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootingCondition(this IEntity obj, AndExpression value) => obj.AddValue(ShootingCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootingCondition(this IEntity obj) => obj.HasValue(ShootingCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootingCondition(this IEntity obj) => obj.DelValue(ShootingCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootingCondition(this IEntity obj, AndExpression value) => obj.SetValue(ShootingCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveBool GetCanShoot(this IEntity obj) => obj.GetValue<ReactiveBool>(CanShoot);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCanShoot(this IEntity obj, out ReactiveBool value) => obj.TryGetValue(CanShoot, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCanShoot(this IEntity obj, ReactiveBool value) => obj.AddValue(CanShoot, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCanShoot(this IEntity obj, ReactiveBool value) => obj.SetValue(CanShoot, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Countdown GetShootTimer(this IEntity obj) => obj.GetValue<Countdown>(ShootTimer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootTimer(this IEntity obj, out Countdown value) => obj.TryGetValue(ShootTimer, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootTimer(this IEntity obj, Countdown value) => obj.AddValue(ShootTimer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootTimer(this IEntity obj) => obj.HasValue(ShootTimer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootTimer(this IEntity obj) => obj.DelValue(ShootTimer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootTimer(this IEntity obj, Countdown value) => obj.SetValue(ShootTimer, value);
    }
}
