using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public sealed class CharacterPushController : MonoBehaviour
    {
        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private PushComponent _tossComponent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Push();

            if (Input.GetKeyDown(KeyCode.Mouse1))
                Toss();
        }

        private void Push()
        {
            _pushComponent.Push();
        }

        private void Toss()
        {
            _tossComponent.Push();
        }
    }
}