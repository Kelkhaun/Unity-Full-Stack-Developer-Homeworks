using System.Collections.Generic;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;
using SampleGame.Common;
using SampleGame.Gameplay;

namespace Game.Scripts.Save.Serializers
{
    public sealed class EntityDestinationSerializer : GameSerializer<EntityWorld, DestinationBook>
    {
        protected override DestinationBook Serialize(EntityWorld entityWorld)
        {
            DestinationBook book = new DestinationBook
            {
                EntitiesDestion = new Dictionary<int, SerializedVector3>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent(out DestinationPoint destinationComponent))
                {
                    book.EntitiesDestion.Add(entity.Id, destinationComponent.Value);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, DestinationBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (entity.TryGetComponent(out DestinationPoint destination))
                {
                    destination.Value = data.EntitiesDestion[entity.Id];
                }
            }
        }
    }

    public struct DestinationBook
    {
        public Dictionary<int, SerializedVector3> EntitiesDestion;
    }
}