using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examprep_70_486.Models
{
    public partial class PartialModel2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
    public partial class PartialModel2
    {
        public List<PartialModel2> partialModel { get; set; }

    }
}