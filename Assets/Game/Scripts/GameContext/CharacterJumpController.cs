using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameContext
{
    public sealed class CharacterJumpController : MonoBehaviour
    {
        [SerializeField]
        private JumpComponent _jumpComponent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Jump();
        }

        private void Jump()
        {
            _jumpComponent.Jump();
        }
    }
}