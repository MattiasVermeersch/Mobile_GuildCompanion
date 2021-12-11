using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class CharacterModel : ModelBase
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
    }
}
