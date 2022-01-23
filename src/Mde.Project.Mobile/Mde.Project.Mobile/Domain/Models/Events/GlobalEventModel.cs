using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class GlobalEventModel : EventModelBase
    {
        //Pvp props
        public string Mode { get; set; }

        //Pve props
        //Dungeon props
        public string Difficulty { get; set; }
        public int? Key { get; set; }
    }
}
