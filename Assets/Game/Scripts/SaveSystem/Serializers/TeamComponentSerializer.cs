using System.Collections.Generic;
using Modules.Entities;
using SampleGame.Common;
using SampleGame.Gameplay;

namespace Game.Scripts.SaveSystem.Serializers
{
    public sealed class TeamComponentSerializer : GameSerializer<EntityWorld, EntityTeamBook>
    {
        protected override EntityTeamBook Serialize(EntityWorld entityWorld)
        {
            EntityTeamBook book = new EntityTeamBook
            {
                Entities = new Dictionary<int, TeamData>()
            };

            foreach (var entity in entityWorld.GetAll())
            {
                if (entity.TryGetComponent<Team>(out var healthComponent))
                {
                    var data = new TeamData()
                    {
                        Id = entity.Id,
                        Team = healthComponent.Type
                    };

                    book.Entities.Add(entity.Id, data);
                }
            }

            return book;
        }

        protected override void Deserialize(EntityWorld service, EntityTeamBook data)
        {
            var entities = service.GetAll();

            foreach (var entity in entities)
            {
                if (data.Entities.TryGetValue(entity.Id, out var teamData))
                {
                    if (entity.TryGetComponent<Team>(out var teamComponent))
                    {
                        teamComponent.Type = teamData.Team;
                    }
                }
            }
        }
    }

    public struct TeamData
    {
        public int Id;
        public TeamType Team;
    }

    public struct EntityTeamBook
    {
        public Dictionary<int, TeamData> Entities;
    }
}