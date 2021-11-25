using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Raid : PveInstance
    {
        public int AvailableBosses { get; set; }
        public int BossesKilled { get; set; }
        public ICollection<RaidCharacter> RaidCharacters { get; set; }
    }
}
