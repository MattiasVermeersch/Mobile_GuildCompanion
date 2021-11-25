using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class PveInstance : BaseEntity
    {
        public string InstanceName { get; set; }
        public string Difficulty { get; set; }
        public DateTime Date { get; set; }
    }
}
