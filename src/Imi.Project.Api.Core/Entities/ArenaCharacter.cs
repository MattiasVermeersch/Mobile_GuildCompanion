using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class ArenaCharacter
    {
        public Guid ArenaId { get; set; }
        public Guid CharacterId { get; set; }
        public Arena Arena { get; set; }
        public Character Character { get; set; }
    }
}
