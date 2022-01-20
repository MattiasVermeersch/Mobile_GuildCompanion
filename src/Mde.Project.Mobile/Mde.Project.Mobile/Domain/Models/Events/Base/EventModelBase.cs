using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public abstract class EventModelBase : ModelBase
    {
        public DateTime Date { get; set; }
        public string InstanceName { get; set; }
        public ICollection<CharacterModel> Characters { get; set; }
    }
}
