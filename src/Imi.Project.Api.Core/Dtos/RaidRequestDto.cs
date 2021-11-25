using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class RaidRequestDto : BaseDto
    {
        public string InstanceName { get; set; }
        public string Difficulty { get; set; }
        public DateTime Date { get; set; }
    }
}
