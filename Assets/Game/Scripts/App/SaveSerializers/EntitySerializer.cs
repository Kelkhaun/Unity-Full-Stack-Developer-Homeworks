using System.Collections.Generic;
using Game.Scripts.App.Common;
using Modules.Entities;
using Modules.SaveSystem.SaveLoader.Serializator;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class EntitySerializer : GameSerializer<EntityWorld, EntityDataSet>
    {
        protected override EntityDataSet Serialize(EntityWorld entityWorld)
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
        
            EntityDataSet dataSet = new EntityDataSet{ Entities = entityDatas };

            return dataSet;
        }

        protected override void Deserialize(EntityWorld entityWorld, EntityDataSet data)
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

    public struct EntityDataSet
    {
        public  List<EntityData> Entities;
    }
}