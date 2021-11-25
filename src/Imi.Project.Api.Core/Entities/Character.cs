using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }
        public int ItemLevel { get; set; }
        public int ArenaRating { get; set; } = 0;
        public int BattlegroundRating { get; set; } = 0;
        public bool IsDeleted { get; set; } = false;
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<ArenaCharacter> ArenaCharacters { get; set; }
        public ICollection<BattlegroundCharacter> BattlegroundCharacters { get; set; }
        public ICollection<DungeonCharacter> DungeonCharacters { get; set; }
        public ICollection<RaidCharacter> RaidCharacters { get; set; }
    }
}
