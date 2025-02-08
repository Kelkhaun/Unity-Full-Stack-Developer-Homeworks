using Game.Scripts.Components;
using UnityEngine;

namespace Game.Scripts.Agents
{
    public sealed class SpiderAgent : MonoBehaviour
    {
        [SerializeField]
        private TimerComponent _pushTimerComponent;

        [SerializeField]
        private PushComponent _pushComponent;

        private void Awake()
        {
            _pushComponent.AddCondition(() => !_pushTimerComponent.IsOnCooldown);
        }
    }
}