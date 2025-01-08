using System.Collections.Generic;
using Game.Scripts.SaveSystem.Serializer;
using Modules.Entities;
using SampleGame.Gameplay;

namespace Game.Scripts.Save.Serializers
{
    public sealed class CountdownSerializer : GameSerializer<EntityWorld, CountdownBook>
    {
        protected override CountdownBook Serialize(EntityWorld entityWorld)
        {
            CountdownBook book = new CountdownBook
            {
                Countdowns = new Dictionary<int, float>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent<Countdown>(out var countdownComponent))
                {
                    book.Countdowns.Add(entity.Id, countdownComponent.Current);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, CountdownBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (entity.TryGetComponent<Countdown>(out var countdownComponent))
                {
                    countdownComponent.Current = data.Countdowns[entity.Id];
                }
            }
        }
    }

    public struct CountdownBook
    {
        public Dictionary<int, float> Countdowns;
    }
}