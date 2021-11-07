using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class DummyProfile
    {
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string DiscordID { get; set; }
    }
}
