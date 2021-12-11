using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class DungeonModel : EventModelBase
    {
        public string Difficulty { get; set; }
        public int? Key { get; set; }
        public bool Success { get; set; }
    }
}
