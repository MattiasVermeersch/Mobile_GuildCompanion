using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class BattlegroundRequestDto : BaseDto
    {
        public string InstanceName { get; set; }
        public bool IsWon { get; set; }
        public DateTime Date { get; set; }
    }
}
