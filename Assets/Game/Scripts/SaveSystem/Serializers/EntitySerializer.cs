using System.Collections.Generic;
using Game.Scripts.Common;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;

namespace Game.Scripts.Save.Serializers
{
    public sealed class EntitySerializer : GameSerializer<EntityWorld, EntitiesBook>
    {
        protected override EntitiesBook Serialize(EntityWorld entityWorld)
        {
            var entities = entityWorld.GetAll();
            List<EntityData> entityDatas = new();

            foreach (var entity in entities)
            {
                entityDatas.Add(new EntityData
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Position = entity.transform.position,
                    Rotation = entity.transform.rotation,
                });
            }
        
            EntitiesBook book = new EntitiesBook{ Entities = entityDatas };

            return book;
        }

        protected override void Deserialize(EntityWorld entityWorld, EntitiesBook data)
        {
            entityWorld.DestroyAll();

            foreach (var entity in data.Entities)
            {
                entityWorld.Spawn(entity.Name, entity.Position, entity.Rotation, entity.Id);
            }
        }
    }

    public struct EntityData
    {
        public int Id;
        public string Name;
        public SerializedVector3 Position;
        public SerializedVector3 Rotation;
    }

    public struct EntitiesBook
    {
        public  List<EntityData> Entities;
    }
}