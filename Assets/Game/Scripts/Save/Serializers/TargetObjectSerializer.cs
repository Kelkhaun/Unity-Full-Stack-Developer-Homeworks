using System.Collections.Generic;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;
using SampleGame.Gameplay;

namespace Game.Scripts.Save.Serializers
{
    public sealed class TargetObjectSerializer : GameSerializer<EntityWorld, TargetObjectBook>
    {
        protected override TargetObjectBook Serialize(EntityWorld entityWorld)
        {
            TargetObjectBook book = new TargetObjectBook
            {
                EntitiesTarget = new Dictionary<int, int>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent(out TargetObject targetObject) && targetObject.Value != null)
                {
                    book.EntitiesTarget.Add(entity.Id, targetObject.Value.Id);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, TargetObjectBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (data.EntitiesTarget.ContainsKey(entity.Id) && entity.TryGetComponent(out TargetObject targetObject))
                {
                    targetObject.Value = service.Get(data.EntitiesTarget[entity.Id]);
                }
            }
        }
    }

    public struct TargetObjectBook
    {
        public Dictionary<int, int> EntitiesTarget;
    }
}