using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Components.Finders
{
    public abstract class FindTargetComponent : MonoBehaviour
    {
        [SerializeField]
        protected List<GameObject> _targets = new();

        public abstract List<GameObject> GetTargets();
    }
}