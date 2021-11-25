using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //create tables
        //public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Arena> Arenas { get; set; }
        public DbSet<Battleground> Battlegrounds { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<Raid> Raids { get; set; }

        //create many-to-many tables
        public DbSet<ArenaCharacter> ArenaCharacters { get; set; }
        public DbSet<BattlegroundCharacter> BattlegroundCharacters { get; set; }
        public DbSet<DungeonCharacter> DungeonCharacters { get; set; }
        public DbSet<RaidCharacter> RaidCharacters { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //create relation for ArenaCharacter
            modelBuilder.Entity<ArenaCharacter>()
                .ToTable("ArenaCharacter")
                .HasKey(ac => new { ac.ArenaId, ac.CharacterId });
            modelBuilder.Entity<ArenaCharacter>()
                .HasOne(ac => ac.Arena)
                .WithMany(a => a.ArenaCharacters)
                .HasForeignKey(ac => ac.ArenaId);
            modelBuilder.Entity<ArenaCharacter>()
                .HasOne(ac => ac.Character)
                .WithMany(c => c.ArenaCharacters)
                .HasForeignKey(ac => ac.CharacterId);

            //create releation for BattlegroundCharacter
            modelBuilder.Entity<BattlegroundCharacter>()
                .ToTable("BattlegroundCharacter")
                .HasKey(bc => new { bc.BattlegroundId, bc.CharacterId });
            modelBuilder.Entity<BattlegroundCharacter>()
                .HasOne(bc => bc.Battleground)
                .WithMany(b => b.BattlegroundCharacters)
                .HasForeignKey(bc => bc.BattlegroundId);
            modelBuilder.Entity<BattlegroundCharacter>()
                .HasOne(bc => bc.Character)
                .WithMany(c => c.BattlegroundCharacters)
                .HasForeignKey(bc => bc.CharacterId);

            //create relation for DungeonCharacter
            modelBuilder.Entity<DungeonCharacter>()
                .ToTable("DungeonCharacter")
                .HasKey(dc => new { dc.DungeonId, dc.CharacterId });
            modelBuilder.Entity<DungeonCharacter>()
                .HasOne(dc => dc.Dungeon)
                .WithMany(d => d.DungeonCharacters)
                .HasForeignKey(dc => dc.DungeonId);
            modelBuilder.Entity<DungeonCharacter>()
                .HasOne(dc => dc.Character)
                .WithMany(c => c.DungeonCharacters)
                .HasForeignKey(dc => dc.CharacterId);

            //create relation for RaidCharacter
            modelBuilder.Entity<RaidCharacter>()
                .ToTable("RaidCharacter")
                .HasKey(dc => new { dc.RaidId, dc.CharacterId });
            modelBuilder.Entity<RaidCharacter>()
                .HasOne(dc => dc.Raid)
                .WithMany(r => r.RaidCharacters)
                .HasForeignKey(dc => dc.RaidId);
            modelBuilder.Entity<RaidCharacter>()
                .HasOne(dc => dc.Character)
                .WithMany(c => c.RaidCharacters)
                .HasForeignKey(dc => dc.CharacterId);

            //IdentityUser config
            modelBuilder.Entity<User>()
                .Property(p => p.ConcurrencyStamp).IsConcurrencyToken(false);

            base.OnModelCreating(modelBuilder);

            //seeding the data
            UserSeeder.Seed(modelBuilder);
            CharacterSeeder.Seed(modelBuilder);
            ArenaSeeder.Seed(modelBuilder);
            BattlegroundSeeder.Seed(modelBuilder);
            DungeonSeeder.Seed(modelBuilder);
            RaidSeeder.Seed(modelBuilder);

            ArenaCharacterSeeder.Seed(modelBuilder);
            BattlegroundCharacterSeeder.Seed(modelBuilder);
            DungeonCharacterSeeder.Seed(modelBuilder);
            RaidCharacterSeeder.Seed(modelBuilder);
        }
    }
}
