using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examprep_70_486.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Role> Roles { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}