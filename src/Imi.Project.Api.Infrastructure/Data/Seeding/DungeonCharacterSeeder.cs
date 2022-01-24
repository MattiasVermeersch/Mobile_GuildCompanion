using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DungeonCharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DungeonCharacter>().HasData(
                //first dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0001-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0019-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0013-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0022-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0030-000000000000")
                },

                //second dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0019-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0013-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0022-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0030-000000000000")
                },

                //third dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0019-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0013-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0022-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0030-000000000000")
                },

                //fourth dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0013-000000000000")
                },

                //fifth dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0013-000000000000")
                },

                //sixth dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0011-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0029-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0027-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0021-000000000000")
                },

                //seventh dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0011-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0029-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0027-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0021-000000000000")
                },

                //eigth dungeon
                new DungeonCharacter
                {
                    //Tank
                    DungeonId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0011-000000000000")
                },
                new DungeonCharacter
                {
                    //Healer
                    DungeonId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps1
                    DungeonId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0029-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps2
                    DungeonId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0027-000000000000")
                },
                new DungeonCharacter
                {
                    //Dps3
                    DungeonId = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0021-000000000000")
                }
            );
        }
    }
}
