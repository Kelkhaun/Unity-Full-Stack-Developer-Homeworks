using System.Collections.Generic;
using Game.Scripts.App.Common;
using Game.Scripts.Gameplay.Components;
using Modules.Entities;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class TeamComponentSerializer : EntityComponentSerializer<EntityWorld, EntityTeamDataSet, Team>
    {
        protected override EntityTeamDataSet Serialize(EntityWorld entityWorld, Dictionary<int, Team> components)
        {
            EntityTeamDataSet dataSet = new EntityTeamDataSet
            {
                Entities = new Dictionary<int, TeamType>()
            };

            foreach (var component in components)
            {
                dataSet.Entities.Add(component.Key, component.Value.Type);
            }

            return dataSet;
        }

        protected override void Deserialize(EntityWorld service, EntityTeamDataSet data, Dictionary<int, Team> components)
        {
            foreach (var component in components)
            {
                if (data.Entities.ContainsKey(component.Key))
                {
                    component.Value.Type = data.Entities[component.Key];
                }
            }
        }
    }

    public struct EntityTeamDataSet
    {
        public Dictionary<int, TeamType> Entities;
    }
}