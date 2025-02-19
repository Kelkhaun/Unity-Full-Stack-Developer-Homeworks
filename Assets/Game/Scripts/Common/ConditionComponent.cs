using System;
using UnityEngine;

namespace Game.Scripts.Common
{
    public class ConditionComponent : MonoBehaviour
    {
        protected CompositeCondition CompositeCondition = new();

        public void AddCondition(Func<bool> condition)
        {
            CompositeCondition.AddCondition(condition);
        }

        public void RemoveCondition(Func<bool> condition)
        {
            CompositeCondition.RemoveCondition(condition);
        }
    }
}