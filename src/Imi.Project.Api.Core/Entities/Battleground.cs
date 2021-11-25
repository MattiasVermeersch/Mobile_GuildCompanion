using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Battleground : PvpInstance
    {
        public string InstanceName { get; set; }
        public ICollection<BattlegroundCharacter> BattlegroundCharacters { get; set; }
    }
}
