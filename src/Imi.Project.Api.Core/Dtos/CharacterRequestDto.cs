using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class CharacterRequestDto : BaseDto
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }
        public int ItemLevel { get; set; }
        public double ArenaRating { get; set; }
        public double BattlegroundRating { get; set; }
        public string UserId { get; set; }
    }
}
