using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class
        TargetObjectSerializer : EntityComponentSerializer<EntityWorld, TargetObjectDataSet, TargetObject>
    {
        protected override TargetObjectDataSet Serialize(EntityWorld entityWorld,
            Dictionary<int, TargetObject> components)
        {
            TargetObjectDataSet dataSet = new TargetObjectDataSet
            {
                EntitiesTarget = new Dictionary<int, int>()
            };

            foreach (var component in components)
            {
                if (component.Value.Value != null)
                    dataSet.EntitiesTarget.Add(component.Key, component.Value.Value.Id);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, TargetObjectDataSet data,
            Dictionary<int, TargetObject> components)
        {
            foreach (var component in components)
            {
                if (data.EntitiesTarget.ContainsKey(component.Key))
                {
                    component.Value.Value = service.Get(data.EntitiesTarget[component.Key]);
                }
            }

        }
    }

    public struct TargetObjectDataSet
    {
        public Dictionary<int, int> EntitiesTarget;
    }
}