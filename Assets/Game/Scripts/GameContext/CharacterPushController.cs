using Game.Scripts.GameObjects.Content;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameContext
{
    public sealed class CharacterPushController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _character;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Push();

            if (Input.GetKeyDown(KeyCode.Mouse1))
                Toss();
        }

        private void Push()
        {
            _character.GetComponent<IPushComponent>().Push();
        }

        private void Toss()
        {
            _character.GetComponent<ITossComponent>().Toss();
        }
    }

}