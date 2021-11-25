using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class RaidCharacter
    {
        public Guid RaidId { get; set; }
        public Guid CharacterId { get; set; }
        public Raid Raid { get; set; }
        public Character Character { get; set; }
    }
}
