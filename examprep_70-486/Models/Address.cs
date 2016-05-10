using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examprep_70_486.Models
{
    public class Address
    {
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }

    public class Address2 : Address
    {
        public bool IsBuitenverblijf { get; set; }
    }
}