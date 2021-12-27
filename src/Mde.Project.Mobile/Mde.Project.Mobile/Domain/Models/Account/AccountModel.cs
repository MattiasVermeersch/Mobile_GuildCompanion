using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xamarin.Forms;

namespace Mde.Project.Mobile.Domain.Models
{
    public class AccountModel : ModelBase
    {
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string BattleNetId { get; set; }
        public string AvatarPath { get; set; }
    }
}

