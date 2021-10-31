using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class EventsService
    {
        private List<string> pveEvents = new List<string>();
        private List<string> pvpEvents = new List<string>();

        public List<string> GetPveEvents()
        {
            pveEvents = new List<string> { "Pve Event 1", "Pve Event 2", "Pve Event 3" };
            return pveEvents;
        }

        public List<string> GetPvpEvents()
        {
            pvpEvents = new List<string> { "Pvp Event 1", "Pvp Event 2", "Pvp Event 3" };
            return pvpEvents;
        }
    }
}
