using System.Collections.Generic;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class CountdownSerializer : EntityComponentSerializer<EntityWorld, CountdownDataSet, Countdown>
    {
        protected override CountdownDataSet Serialize(EntityWorld entityWorld, Dictionary<int, Countdown> components)
        {
            var dataSet = new CountdownDataSet
            {
                Countdowns = new Dictionary<int, float>()
            };

            foreach (var component in components)
            {
                dataSet.Countdowns.Add(component.Key, component.Value.Current);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, CountdownDataSet data,  Dictionary<int, Countdown> components)
        {
            foreach (var component in components)
            {
                component.Value.Current = data.Countdowns[component.Key];
            }
        }
    }

    public struct CountdownDataSet
    {
        public Dictionary<int, float> Countdowns;
    }
}

