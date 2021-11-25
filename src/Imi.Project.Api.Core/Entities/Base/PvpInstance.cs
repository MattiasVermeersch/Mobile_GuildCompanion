using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class PvpInstance : BaseEntity
    {
        public bool IsWon { get; set; } = false;
        public DateTime Date { get; set; }
        
    }
}
