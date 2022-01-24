using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RaidSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raid>().HasData(
                new Raid
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    InstanceName = "Sanctum of Domination",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 01, 24),
                    BossesKilled = 10
                },
                new Raid
                {
                    Id = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    InstanceName = "Sanctum of Domination",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 03, 07),
                    BossesKilled = 10
                },
                new Raid
                {
                    Id = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    InstanceName = "Sanctum of Domination",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 03, 10),
                    BossesKilled = 10
                },
                new Raid
                {
                    Id = Guid.Parse("40000000-0000-0000-0000-000000000000"),
                    InstanceName = "Sanctum of Domination",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 03, 17),
                    BossesKilled = 4
                },
                new Raid
                {
                    Id = Guid.Parse("50000000-0000-0000-0000-000000000000"),
                    InstanceName = "Sanctum of Domination",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2022, 03, 24),
                    BossesKilled = 4
                }
            );
        }
    }
}
