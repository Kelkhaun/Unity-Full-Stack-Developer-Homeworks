using System.Collections.Generic;
using Game.Scripts.App.Common;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class EntityDestinationSerializer : EntityComponentSerializer<EntityWorld, DestinationDataSet, DestinationPoint>
    {
        protected override DestinationDataSet Serialize(EntityWorld entityWorld,
            Dictionary<int, DestinationPoint> components)
        {
            DestinationDataSet dataSet = new DestinationDataSet
                {EntitiesDestion = new Dictionary<int, SerializedVector3>()};

            foreach (var component in components)
            {
                dataSet.EntitiesDestion.Add(component.Key, component.Value.Value);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, DestinationDataSet data,
            Dictionary<int, DestinationPoint> components)
        {
            foreach (var component in components)
            {
                component.Value.Value = data.EntitiesDestion[component.Key];
            }
        }
    }

    public struct DestinationDataSet
    {
        public Dictionary<int, SerializedVector3> EntitiesDestion;
    }
}