using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;

namespace Game.Scripts.Save.Serializers
{
    public sealed class ProductionOrderSerializer : GameSerializer<EntityWorld, EntityCatalog, ProductionOrderBook>
    {

        protected override ProductionOrderBook Serialize(EntityWorld service1, EntityCatalog service2)
        {
            ProductionOrderBook book = new ProductionOrderBook
            {
                ProductionOrders = new Dictionary<int, List<string>>()
            };

            foreach (var entity in service1.GetAll())
            {
                if (entity.TryGetComponent(out ProductionOrder productionOrder))
                {
                    List<string> names = new List<string>();

                    foreach (var config in productionOrder.Queue)
                    {
                        names.Add(config.Name);
                    }

                    book.ProductionOrders.Add(entity.Id, names);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service1, EntityCatalog service2, ProductionOrderBook data)
        {
            var entities = service1.GetAll();

            foreach (var entity in entities)
            {
                if (entity.TryGetComponent(out ProductionOrder productionOrderComponent))
                {
                    List<EntityConfig> configs = new List<EntityConfig>();

                    foreach (var production in data.ProductionOrders[entity.Id])
                    {
                        if (service2.FindConfig(production, out EntityConfig config))
                            configs.Add(config);
                    }

                    productionOrderComponent.Queue = configs;
                }
            }
        }
    }

    public struct ProductionOrderBook
    {
        public Dictionary<int, List<string>> ProductionOrders;
    }
}