using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DungeonSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dungeon>().HasData(
                new Dungeon
                {
                    Id = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    InstanceName = "De Other Side",
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 01, 26),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    InstanceName = "Mists of Tirna Scithe",
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 01, 31),
                    Succes = true
                }, 
                new Dungeon
                {
                    Id = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    InstanceName = "The Necrotic Wake",
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 02, 20),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    InstanceName = "Plaguefall",
                    Difficulty = "Mythic",
                    Date = new DateTime(2022, 02, 21),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    InstanceName = "Spires of Ascension",
                    Difficulty = "Mythic",
                    Date = new DateTime(2021, 01, 31),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    InstanceName = "Halls of Atonement",
                    Difficulty = "Mythic+ 5",
                    Date = new DateTime(2021, 02, 02),
                    Succes = true,
                    KeyIncrease = 2
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    InstanceName = "Theater of Pain",
                    Difficulty = "Mythic+ 7",
                    Date = new DateTime(2021, 02, 02),
                    Succes = true,
                    KeyIncrease = 1
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    InstanceName = "Sanguine Depths",
                    Difficulty = "Mythic+ 8",
                    Date = new DateTime(2021, 02, 02),
                    Succes = false,
                }
            );
        }
    }
}
