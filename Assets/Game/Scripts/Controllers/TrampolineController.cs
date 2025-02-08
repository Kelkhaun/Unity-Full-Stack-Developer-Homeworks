using Game.Scripts.Components;
using Game.Scripts.Components.Finders;
using UnityEngine;

namespace Game.Scripts.Controllers
{
    public sealed class TrampolineController : MonoBehaviour
    {
        [SerializeField]
        private PushComponent _pushComponent;

        [SerializeField]
        private ColliderFinder _colliderFinder;

        private void OnEnable()
        {
            _colliderFinder.OnTargetAdd.AddListener(_pushComponent.Push);
        }

        private void OnDisable()
        {
            _colliderFinder.OnTargetAdd.RemoveListener(_pushComponent.Push);
        }
    }
}
