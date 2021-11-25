using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Dungeon : PveInstance
    {
        public int? KeyIncrease { get; set; }
        public bool Succes { get; set; }
        public ICollection<DungeonCharacter> DungeonCharacters { get; set; }
    }
}
