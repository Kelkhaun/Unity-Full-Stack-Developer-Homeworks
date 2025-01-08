using System.Collections.Generic;
using Modules.Entities;
using SampleGame.Common;
using SampleGame.Gameplay;

namespace Game.Scripts.Save.Serializers
{
    public sealed class ResourceBagSerializer : GameSerializer<EntityWorld, ResourceBagBook>
    {
        protected override ResourceBagBook Serialize(EntityWorld entityWorld)
        {
            ResourceBagBook book = new ResourceBagBook
            {
                ResourcesBag = new Dictionary<int, ResourceBagData>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent(out ResourceBag resourceBag))
                {
                    book.ResourcesBag.Add(entity.Id, new ResourceBagData
                    {
                        Type = resourceBag.Type,
                        Current = resourceBag.Current
                    });
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, ResourceBagBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (entity.TryGetComponent(out ResourceBag resource))
                {
                    var resourceBagData = data.ResourcesBag[entity.Id];

                    resource.Current = resourceBagData.Current;
                    resource.Type = resourceBagData.Type;
                }
            }
        }
    }

    public struct ResourceBagData
    {
        public ResourceType Type;
        public int Current;
    }

    public struct ResourceBagBook
    {
        public Dictionary<int, ResourceBagData> ResourcesBag;
    }
}