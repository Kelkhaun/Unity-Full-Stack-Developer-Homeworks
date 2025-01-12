using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class
        EntityHealthComponentSerializer : EntityComponentSerializer<EntityWorld, EntityHealthDataSet, Health>
    {
        protected override EntityHealthDataSet Serialize(EntityWorld entityWorld,
            Dictionary<int, Health> components)
        {
            EntityHealthDataSet dataSet = new EntityHealthDataSet {EntitiesHealth = new Dictionary<int, int>()};

            foreach (var component in components)
            {
                dataSet.EntitiesHealth.Add(component.Key, component.Value.Current);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, EntityHealthDataSet data,
            Dictionary<int, Health> components)
        {
            foreach (var component in components)
            {
                component.Value.Current = data.EntitiesHealth[component.Key];
            }
        }
    }

    public struct EntityHealthDataSet
    {
        public Dictionary<int, int> EntitiesHealth;
    }
}