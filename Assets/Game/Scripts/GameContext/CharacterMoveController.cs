using Game.Scripts.GameObjects.Content;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameContext
{
    public sealed class CharacterMoveController : MonoBehaviour
    {
        private string HORIZONTAL_AXIS = "Horizontal";

        [SerializeField]
        private Character _character;

        private Vector2 _direction;

        private void Update()
        {
            _direction.x = Input.GetAxisRaw(HORIZONTAL_AXIS);

            _character.GetComponent<MoveComponent>().Move(_direction);
        }
    }
}