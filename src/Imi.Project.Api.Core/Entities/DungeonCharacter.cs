using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class DungeonCharacter
    {
        public Guid DungeonId { get; set; }
        public Guid CharacterId { get; set; }
        public Dungeon Dungeon { get; set; }
        public Character Character { get; set; }
    }
}
