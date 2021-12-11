using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class RaidModel : EventModelBase
    {
        public int Bosses { get; set; }
        public int BossesDown { get; set; }
    }
}
