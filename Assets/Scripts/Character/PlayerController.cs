using Input;
using UnityEngine;

namespace Character
{
    public sealed class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private Player _player;

        [SerializeField]
        private KeyboardInput _keyboardInput;

        private void OnEnable()
        {
            _keyboardInput.OnMove += _player.Move;
            _keyboardInput.OnFire += _player.Shoot;
        }

        private void OnDisable()
        {
            _keyboardInput.OnMove -= _player.Move;
            _keyboardInput.OnFire -= _player.Shoot;
        }
    }
}