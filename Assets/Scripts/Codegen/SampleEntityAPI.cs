/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using Atomic.Elements;
using Modules.Gameplay;
using Game.Scripts.Types;

namespace SampleGame
{
	public static class SampleEntityAPI
	{
		///Tags
		public const int Player = -1615495341;
		public const int Enemy = 979269037;
		public const int Resource = 1172805184;
		public const int Interactable = 1077199658;


		///Values
		public const int CurrentHealth = 1412363848; // ReactiveInt
		public const int MaxHealth = 1923500305; // ReactiveInt
		public const int DeathEvent = -1096613677; // IEvent
		public const int Transform = -180157682; // Transform
		public const int Rigidbody = -2101481708; // Rigidbody
		public const int MoveDirection = -721923052; // ReactiveVector3
		public const int MoveSpeed = 526065662; // ReactiveFloat
		public const int RotateDirection = -1044844011; // ReactiveVector3
		public const int RotationSpeed = 1771316350; // ReactiveFloat
		public const int ShootEvent = -1898355213; // IEvent
		public const int ShootingRequest = -1070173053; // IEvent
		public const int ShootingOverRequest = -65613924; // IEvent
		public const int ShootingCondition = 1909327147; // AndExpression
		public const int CanShoot = -1431824453; // ReactiveBool
		public const int ShootTimer = -542658226; // Countdown
		public const int LifeTimeCountdown = 249824570; // Timer
		public const int GameObject = 1482111001; // GameObject
		public const int CollisionEventReceiver = 396602988; // CollisionEventReceiver
		public const int TriggerEventReceiver = -484936241; // TriggerEventReceiver
		public const int Damage = 375673178; // ReactiveInt
		public const int Weapon = 1855955664; // WeaponEntity
		public const int InteractAction = -1026843572; // BaseAction<IEntity>
		public const int Target = 1103309514; // ReactiveVariable<IEntity>


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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractableTag(this IEntity obj) => obj.HasTag(Interactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractableTag(this IEntity obj) => obj.AddTag(Interactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractableTag(this IEntity obj) => obj.DelTag(Interactable);


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetCurrentHealth(this IEntity obj) => obj.GetValue<ReactiveInt>(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentHealth(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(CurrentHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentHealth(this IEntity obj, ReactiveInt value) => obj.AddValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentHealth(this IEntity obj) => obj.HasValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentHealth(this IEntity obj) => obj.DelValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentHealth(this IEntity obj, ReactiveInt value) => obj.SetValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetMaxHealth(this IEntity obj) => obj.GetValue<ReactiveInt>(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxHealth(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(MaxHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaxHealth(this IEntity obj, ReactiveInt value) => obj.AddValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxHealth(this IEntity obj) => obj.HasValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxHealth(this IEntity obj) => obj.DelValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxHealth(this IEntity obj, ReactiveInt value) => obj.SetValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetDeathEvent(this IEntity obj) => obj.GetValue<IEvent>(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDeathEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(DeathEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDeathEvent(this IEntity obj, IEvent value) => obj.AddValue(DeathEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDeathEvent(this IEntity obj) => obj.HasValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDeathEvent(this IEntity obj) => obj.DelValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDeathEvent(this IEntity obj, IEvent value) => obj.SetValue(DeathEvent, value);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Timer GetLifeTimeCountdown(this IEntity obj) => obj.GetValue<Timer>(LifeTimeCountdown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifeTimeCountdown(this IEntity obj, out Timer value) => obj.TryGetValue(LifeTimeCountdown, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddLifeTimeCountdown(this IEntity obj, Timer value) => obj.AddValue(LifeTimeCountdown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifeTimeCountdown(this IEntity obj) => obj.HasValue(LifeTimeCountdown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifeTimeCountdown(this IEntity obj) => obj.DelValue(LifeTimeCountdown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifeTimeCountdown(this IEntity obj, Timer value) => obj.SetValue(LifeTimeCountdown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetGameObject(this IEntity obj) => obj.GetValue<GameObject>(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameObject(this IEntity obj, out GameObject value) => obj.TryGetValue(GameObject, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameObject(this IEntity obj, GameObject value) => obj.AddValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameObject(this IEntity obj) => obj.HasValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameObject(this IEntity obj) => obj.DelValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameObject(this IEntity obj, GameObject value) => obj.SetValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CollisionEventReceiver GetCollisionEventReceiver(this IEntity obj) => obj.GetValue<CollisionEventReceiver>(CollisionEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCollisionEventReceiver(this IEntity obj, out CollisionEventReceiver value) => obj.TryGetValue(CollisionEventReceiver, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCollisionEventReceiver(this IEntity obj, CollisionEventReceiver value) => obj.AddValue(CollisionEventReceiver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCollisionEventReceiver(this IEntity obj) => obj.HasValue(CollisionEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCollisionEventReceiver(this IEntity obj) => obj.DelValue(CollisionEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCollisionEventReceiver(this IEntity obj, CollisionEventReceiver value) => obj.SetValue(CollisionEventReceiver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerEventReceiver GetTriggerEventReceiver(this IEntity obj) => obj.GetValue<TriggerEventReceiver>(TriggerEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerEventReceiver(this IEntity obj, out TriggerEventReceiver value) => obj.TryGetValue(TriggerEventReceiver, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTriggerEventReceiver(this IEntity obj, TriggerEventReceiver value) => obj.AddValue(TriggerEventReceiver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerEventReceiver(this IEntity obj) => obj.HasValue(TriggerEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerEventReceiver(this IEntity obj) => obj.DelValue(TriggerEventReceiver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerEventReceiver(this IEntity obj, TriggerEventReceiver value) => obj.SetValue(TriggerEventReceiver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetDamage(this IEntity obj) => obj.GetValue<ReactiveInt>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamage(this IEntity obj, ReactiveInt value) => obj.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IEntity obj, ReactiveInt value) => obj.SetValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static WeaponEntity GetWeapon(this IEntity obj) => obj.GetValue<WeaponEntity>(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeapon(this IEntity obj, out WeaponEntity value) => obj.TryGetValue(Weapon, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeapon(this IEntity obj, WeaponEntity value) => obj.AddValue(Weapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeapon(this IEntity obj) => obj.HasValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeapon(this IEntity obj) => obj.DelValue(Weapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeapon(this IEntity obj, WeaponEntity value) => obj.SetValue(Weapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BaseAction<IEntity> GetInteractAction(this IEntity obj) => obj.GetValue<BaseAction<IEntity>>(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInteractAction(this IEntity obj, out BaseAction<IEntity> value) => obj.TryGetValue(InteractAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractAction(this IEntity obj, BaseAction<IEntity> value) => obj.AddValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractAction(this IEntity obj) => obj.HasValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractAction(this IEntity obj) => obj.DelValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInteractAction(this IEntity obj, BaseAction<IEntity> value) => obj.SetValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<IEntity> GetTarget(this IEntity obj) => obj.GetValue<ReactiveVariable<IEntity>>(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IEntity obj, out ReactiveVariable<IEntity> value) => obj.TryGetValue(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTarget(this IEntity obj, ReactiveVariable<IEntity> value) => obj.AddValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IEntity obj) => obj.HasValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IEntity obj) => obj.DelValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IEntity obj, ReactiveVariable<IEntity> value) => obj.SetValue(Target, value);
    }
}
