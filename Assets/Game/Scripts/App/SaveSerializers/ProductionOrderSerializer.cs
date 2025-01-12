using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class ProductionOrderSerializer : EntityComponentSerializer<EntityCatalog, ProductionOrderDataSet, ProductionOrder>
    {
        protected override ProductionOrderDataSet Serialize(EntityCatalog entityCatalog, Dictionary<int, ProductionOrder> components)
        {
            ProductionOrderDataSet dataSet = new ProductionOrderDataSet
            {
                ProductionOrders = new Dictionary<int, List<string>>()
            };

            foreach (var component in components)
            {
                List<string> names = new List<string>();

                foreach (var config in component.Value.Queue)
                {
                    names.Add(config.Name);
                }

                dataSet.ProductionOrders.Add(component.Key, names);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityCatalog entityCatalog, ProductionOrderDataSet data, Dictionary<int, ProductionOrder> components)
        {
            foreach (var component in components)
            {
                List<EntityConfig> configs = new List<EntityConfig>();

                foreach (var production in data.ProductionOrders[component.Key])
                {
                    if (entityCatalog.FindConfig(production, out EntityConfig config))
                        configs.Add(config);
                }

                component.Value.Queue = configs;
            }
        }
    }

    public struct ProductionOrderDataSet
    {
        public Dictionary<int, List<string>> ProductionOrders;
    }
}