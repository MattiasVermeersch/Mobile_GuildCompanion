using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Arena : PvpInstance
    {
        public ICollection<ArenaCharacter> ArenaCharacters { get; set; }
    }
}
