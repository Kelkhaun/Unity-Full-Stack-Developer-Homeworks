/**
* Code generation. Don't modify! 
**/

using Atomic.Contexts;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using Atomic.Contexts;
using Modules.Common;

namespace SampleGame
{
	public static class SampleContextAPI
	{


		///Values
		public const int MoveJoystick = -1686028204; // Joystick
		public const int AimJoystick = -1668784795; // Joystick
		public const int Character = 294335127; // SceneEntity


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
    }
}
