using Game.Scripts.GameObjects.Content;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameContext
{
    public sealed class CharacterJumpController : MonoBehaviour
    {
        [SerializeField]
        private Character _character;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Jump();
        }

        private void Jump()
        {
            _character.GetComponent<JumpComponent>().Jump();
        }
    }
}