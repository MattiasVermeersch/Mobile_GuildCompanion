using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class EventListItemModel : ModelBase
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}
