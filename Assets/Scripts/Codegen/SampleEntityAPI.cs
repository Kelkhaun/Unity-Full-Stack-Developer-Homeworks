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
using Game.Scripts.Gameplay.Entity.Common.TakeDamage;

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
		public const int MinDistance = 1338947382; // ReactiveFloat
		public const int DeathEvent = -1096613677; // IEvent
		public const int Transform = -180157682; // Transform
		public const int Rigidbody = -2101481708; // Rigidbody
		public const int MoveDirection = -721923052; // ReactiveVector3
		public const int MoveSpeed = 526065662; // ReactiveFloat
		public const int RotateDirection = -1044844011; // ReactiveVector3
		public const int IsAiming = 2025090383; // ReactiveBool
		public const int RotationSpeed = 1771316350; // ReactiveFloat
		public const int AttackEvent = -691201150; // IEvent
		public const int AttackRequest = -1177251095; // IEvent
		public const int AttackOverRequest = 1081289759; // IEvent
		public const int AttackCondition = -1481262935; // AndExpression
		public const int CanAttack = 930100575; // ReactiveBool
		public const int CanHit = -629424609; // ReactiveBool
		public const int AttackCooldown = 1736948685; // Countdown
		public const int LifeTimeCountdown = 249824570; // Timer
		public const int GameObject = 1482111001; // GameObject
		public const int CollisionEventReceiver = 396602988; // CollisionEventReceiver
		public const int TriggerEventReceiver = -484936241; // TriggerEventReceiver
		public const int Damage = 375673178; // ReactiveInt
		public const int Weapon = 1855955664; // WeaponEntity
		public const int InteractEvent = 1502481653; // BaseEvent<IEntity>
		public const int Target = 1103309514; // ReactiveVariable<IEntity>
		public const int WeaponType = -1936256502; // WeaponType
		public const int Animator = -1714818978; // Animator
		public const int AudioSource = 907064781; // AudioSource
		public const int TakeDamageSounds = 1392262112; // PainSoundBehaviour.Level[]
		public const int Clips = 162804960; // ReactiveInt
		public const int AddedHealth = 981746382; // ReactiveInt
		public const int InteractableItemSuccess = -200226185; // BaseEvent
		public const int BoxCollider = -664938726; // BoxCollider


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
		public static ReactiveFloat GetMinDistance(this IEntity obj) => obj.GetValue<ReactiveFloat>(MinDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMinDistance(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(MinDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMinDistance(this IEntity obj, ReactiveFloat value) => obj.AddValue(MinDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMinDistance(this IEntity obj) => obj.HasValue(MinDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMinDistance(this IEntity obj) => obj.DelValue(MinDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMinDistance(this IEntity obj, ReactiveFloat value) => obj.SetValue(MinDistance, value);

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
		public static ReactiveBool GetIsAiming(this IEntity obj) => obj.GetValue<ReactiveBool>(IsAiming);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsAiming(this IEntity obj, out ReactiveBool value) => obj.TryGetValue(IsAiming, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsAiming(this IEntity obj, ReactiveBool value) => obj.AddValue(IsAiming, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsAiming(this IEntity obj) => obj.HasValue(IsAiming);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsAiming(this IEntity obj) => obj.DelValue(IsAiming);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsAiming(this IEntity obj, ReactiveBool value) => obj.SetValue(IsAiming, value);

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
		public static IEvent GetAttackEvent(this IEntity obj) => obj.GetValue<IEvent>(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(AttackEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackEvent(this IEntity obj, IEvent value) => obj.AddValue(AttackEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackEvent(this IEntity obj) => obj.HasValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackEvent(this IEntity obj) => obj.DelValue(AttackEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackEvent(this IEntity obj, IEvent value) => obj.SetValue(AttackEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetAttackRequest(this IEntity obj) => obj.GetValue<IEvent>(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(AttackRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackRequest(this IEntity obj, IEvent value) => obj.AddValue(AttackRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackRequest(this IEntity obj) => obj.HasValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackRequest(this IEntity obj) => obj.DelValue(AttackRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackRequest(this IEntity obj, IEvent value) => obj.SetValue(AttackRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetAttackOverRequest(this IEntity obj) => obj.GetValue<IEvent>(AttackOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackOverRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(AttackOverRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackOverRequest(this IEntity obj, IEvent value) => obj.AddValue(AttackOverRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackOverRequest(this IEntity obj) => obj.HasValue(AttackOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackOverRequest(this IEntity obj) => obj.DelValue(AttackOverRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackOverRequest(this IEntity obj, IEvent value) => obj.SetValue(AttackOverRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AndExpression GetAttackCondition(this IEntity obj) => obj.GetValue<AndExpression>(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackCondition(this IEntity obj, out AndExpression value) => obj.TryGetValue(AttackCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackCondition(this IEntity obj, AndExpression value) => obj.AddValue(AttackCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackCondition(this IEntity obj) => obj.HasValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackCondition(this IEntity obj) => obj.DelValue(AttackCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackCondition(this IEntity obj, AndExpression value) => obj.SetValue(AttackCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveBool GetCanAttack(this IEntity obj) => obj.GetValue<ReactiveBool>(CanAttack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCanAttack(this IEntity obj, out ReactiveBool value) => obj.TryGetValue(CanAttack, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCanAttack(this IEntity obj, ReactiveBool value) => obj.AddValue(CanAttack, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCanAttack(this IEntity obj) => obj.HasValue(CanAttack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCanAttack(this IEntity obj) => obj.DelValue(CanAttack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCanAttack(this IEntity obj, ReactiveBool value) => obj.SetValue(CanAttack, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveBool GetCanHit(this IEntity obj) => obj.GetValue<ReactiveBool>(CanHit);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCanHit(this IEntity obj, out ReactiveBool value) => obj.TryGetValue(CanHit, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCanHit(this IEntity obj, ReactiveBool value) => obj.AddValue(CanHit, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCanHit(this IEntity obj) => obj.HasValue(CanHit);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCanHit(this IEntity obj) => obj.DelValue(CanHit);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCanHit(this IEntity obj, ReactiveBool value) => obj.SetValue(CanHit, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Countdown GetAttackCooldown(this IEntity obj) => obj.GetValue<Countdown>(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackCooldown(this IEntity obj, out Countdown value) => obj.TryGetValue(AttackCooldown, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackCooldown(this IEntity obj, Countdown value) => obj.AddValue(AttackCooldown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackCooldown(this IEntity obj) => obj.HasValue(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackCooldown(this IEntity obj) => obj.DelValue(AttackCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackCooldown(this IEntity obj, Countdown value) => obj.SetValue(AttackCooldown, value);

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
		public static BaseEvent<IEntity> GetInteractEvent(this IEntity obj) => obj.GetValue<BaseEvent<IEntity>>(InteractEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInteractEvent(this IEntity obj, out BaseEvent<IEntity> value) => obj.TryGetValue(InteractEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractEvent(this IEntity obj, BaseEvent<IEntity> value) => obj.AddValue(InteractEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractEvent(this IEntity obj) => obj.HasValue(InteractEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractEvent(this IEntity obj) => obj.DelValue(InteractEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInteractEvent(this IEntity obj, BaseEvent<IEntity> value) => obj.SetValue(InteractEvent, value);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static WeaponType GetWeaponType(this IEntity obj) => obj.GetValue<WeaponType>(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponType(this IEntity obj, out WeaponType value) => obj.TryGetValue(WeaponType, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponType(this IEntity obj, WeaponType value) => obj.AddValue(WeaponType, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponType(this IEntity obj) => obj.HasValue(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponType(this IEntity obj) => obj.DelValue(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponType(this IEntity obj, WeaponType value) => obj.SetValue(WeaponType, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IEntity obj) => obj.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IEntity obj, out Animator value) => obj.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimator(this IEntity obj, Animator value) => obj.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IEntity obj) => obj.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IEntity obj) => obj.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IEntity obj, Animator value) => obj.SetValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AudioSource GetAudioSource(this IEntity obj) => obj.GetValue<AudioSource>(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAudioSource(this IEntity obj, out AudioSource value) => obj.TryGetValue(AudioSource, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAudioSource(this IEntity obj, AudioSource value) => obj.AddValue(AudioSource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAudioSource(this IEntity obj) => obj.HasValue(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAudioSource(this IEntity obj) => obj.DelValue(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAudioSource(this IEntity obj, AudioSource value) => obj.SetValue(AudioSource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static PainSoundBehaviour.Level[] GetTakeDamageSounds(this IEntity obj) => obj.GetValue<PainSoundBehaviour.Level[]>(TakeDamageSounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTakeDamageSounds(this IEntity obj, out PainSoundBehaviour.Level[] value) => obj.TryGetValue(TakeDamageSounds, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTakeDamageSounds(this IEntity obj, PainSoundBehaviour.Level[] value) => obj.AddValue(TakeDamageSounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTakeDamageSounds(this IEntity obj) => obj.HasValue(TakeDamageSounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTakeDamageSounds(this IEntity obj) => obj.DelValue(TakeDamageSounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTakeDamageSounds(this IEntity obj, PainSoundBehaviour.Level[] value) => obj.SetValue(TakeDamageSounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetClips(this IEntity obj) => obj.GetValue<ReactiveInt>(Clips);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetClips(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(Clips, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddClips(this IEntity obj, ReactiveInt value) => obj.AddValue(Clips, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasClips(this IEntity obj) => obj.HasValue(Clips);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelClips(this IEntity obj) => obj.DelValue(Clips);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetClips(this IEntity obj, ReactiveInt value) => obj.SetValue(Clips, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveInt GetAddedHealth(this IEntity obj) => obj.GetValue<ReactiveInt>(AddedHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAddedHealth(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(AddedHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAddedHealth(this IEntity obj, ReactiveInt value) => obj.AddValue(AddedHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAddedHealth(this IEntity obj) => obj.HasValue(AddedHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAddedHealth(this IEntity obj) => obj.DelValue(AddedHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAddedHealth(this IEntity obj, ReactiveInt value) => obj.SetValue(AddedHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BaseEvent GetInteractableItemSuccess(this IEntity obj) => obj.GetValue<BaseEvent>(InteractableItemSuccess);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInteractableItemSuccess(this IEntity obj, out BaseEvent value) => obj.TryGetValue(InteractableItemSuccess, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractableItemSuccess(this IEntity obj, BaseEvent value) => obj.AddValue(InteractableItemSuccess, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractableItemSuccess(this IEntity obj) => obj.HasValue(InteractableItemSuccess);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractableItemSuccess(this IEntity obj) => obj.DelValue(InteractableItemSuccess);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInteractableItemSuccess(this IEntity obj, BaseEvent value) => obj.SetValue(InteractableItemSuccess, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BoxCollider GetBoxCollider(this IEntity obj) => obj.GetValue<BoxCollider>(BoxCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBoxCollider(this IEntity obj, out BoxCollider value) => obj.TryGetValue(BoxCollider, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBoxCollider(this IEntity obj, BoxCollider value) => obj.AddValue(BoxCollider, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBoxCollider(this IEntity obj) => obj.HasValue(BoxCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBoxCollider(this IEntity obj) => obj.DelValue(BoxCollider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBoxCollider(this IEntity obj, BoxCollider value) => obj.SetValue(BoxCollider, value);
    }
}
