using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class BattlegroundModel : EventModelBase
    {
        public bool IsWon { get; set; } = false;
    }
}
