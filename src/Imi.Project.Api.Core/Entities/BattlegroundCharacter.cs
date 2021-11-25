using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class BattlegroundCharacter
    {
        public Guid BattlegroundId { get; set; }
        public Guid CharacterId { get; set; }
        public Battleground Battleground { get; set; }
        public Character Character { get; set; }
    }
}
