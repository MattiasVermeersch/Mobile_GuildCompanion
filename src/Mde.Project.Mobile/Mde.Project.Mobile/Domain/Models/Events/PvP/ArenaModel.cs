using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class ArenaModel : EventModelBase
    {
        public string Mode { get; set; }
        public bool IsWon { get; set; } = false;
    }
}
