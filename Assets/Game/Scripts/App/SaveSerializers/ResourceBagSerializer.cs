using System.Collections.Generic;
using Game.Scripts.App.Common;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class ResourceBagSerializer : EntityComponentSerializer<EntityWorld, ResourceBagDataSet, ResourceBag>
    {
        protected override ResourceBagDataSet Serialize(EntityWorld entityWorld, Dictionary<int, ResourceBag> components)
        {
            ResourceBagDataSet dataSet = new ResourceBagDataSet
            {
                ResourcesBag = new Dictionary<int, ResourceBagData>()
            };

            foreach (var component in components)
            {
                dataSet.ResourcesBag.Add(component.Key, new ResourceBagData
                {
                    Type = component.Value.Type,
                    Current = component.Value.Current
                });
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, ResourceBagDataSet data, Dictionary<int, ResourceBag> components)
        {
            foreach (var component in components)
            {
                var resourceBagData = data.ResourcesBag[component.Key];
                component.Value.Current = resourceBagData.Current;
                component.Value.Type = resourceBagData.Type;
            }
        }
    }

    public struct ResourceBagData
    {
        public ResourceType Type;
        public int Current;
    }

    public struct ResourceBagDataSet
    {
        public Dictionary<int, ResourceBagData> ResourcesBag;
    }
}