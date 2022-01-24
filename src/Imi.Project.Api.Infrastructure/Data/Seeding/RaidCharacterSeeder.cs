using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RaidCharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaidCharacter>().HasData(
                //first raid
                new RaidCharacter
                {
                    //Tank 1
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0001-000000000000")
                },
                new RaidCharacter
                {
                    //Tank 2
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 1
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 2
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 3
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 1
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0014-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 2
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 3
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 4
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0012-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 5
                    RaidId = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                },

                //second raid
                new RaidCharacter
                {
                    //Tank 1
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0001-000000000000")
                },
                new RaidCharacter
                {
                    //Tank 2
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 1
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 2
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 3
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 1
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0014-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 2
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 3
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 4
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0012-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 5
                    RaidId = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                },

                //third raid
                new RaidCharacter
                {
                    //Tank 1
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0001-000000000000")
                },
                new RaidCharacter
                {
                    //Tank 2
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 1
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 2
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 3
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 1
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0014-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 2
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 3
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 4
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0012-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 5
                    RaidId = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                },

                //fourth raid
                new RaidCharacter
                {
                    //Tank 1
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0001-000000000000")
                },
                new RaidCharacter
                {
                    //Tank 2
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 1
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 2
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 3
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0018-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 1
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0014-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 2
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 3
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 4
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0012-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 5
                    RaidId = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                },

                //fifth raid
                new RaidCharacter
                {
                    //Tank 1
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new RaidCharacter
                {
                    //Tank 2
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0025-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 1
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 2
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0016-000000000000")
                },
                new RaidCharacter
                {
                    //Healer 3
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0019-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 1
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0014-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 2
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 3
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 4
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0012-000000000000")
                },
                new RaidCharacter
                {
                    //Dps 5
                    RaidId = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                }
            );
        }
    }
}
