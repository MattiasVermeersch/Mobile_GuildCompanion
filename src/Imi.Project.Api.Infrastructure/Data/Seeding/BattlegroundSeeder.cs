using System;
using System.Collections.Generic;
using System.Text;
using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class BattlegroundSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Battleground>().HasData(
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    InstanceName = "Warsong Gulch",
                    Date = new DateTime(2021, 03, 01),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    IsWon = false
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    InstanceName = "Warsong Gulch",
                    Date = new DateTime(2021, 03, 01),
                    IsWon = true
                }
            );
        }
    }
}
