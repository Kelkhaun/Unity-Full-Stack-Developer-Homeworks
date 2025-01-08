using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;

namespace Game.Scripts.Save.Serializers
{
    public sealed class EntityHealthComponentSerializer : GameSerializer<EntityWorld, EntityHealthBook>
    {
        protected override EntityHealthBook Serialize(EntityWorld entityWorld)
        {
            EntityHealthBook book = new EntityHealthBook
            {
                EntitiesHealth = new Dictionary<int, int>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent<Health>(out var healthComponent))
                {
                    book.EntitiesHealth.Add(entity.Id, healthComponent.Current);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, EntityHealthBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (entity.TryGetComponent<Health>(out var healthComponent))
                {
                    healthComponent.Current = data.EntitiesHealth[entity.Id];
                }
            }
        }
    }

    public struct EntityHealthBook
    {
        public Dictionary<int, int> EntitiesHealth;
    }
}