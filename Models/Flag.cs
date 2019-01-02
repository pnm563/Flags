using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Flag
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        
    }

    public class CountryFlag : Flag
    {
        public string CountryCode { get; set; }
    }
}
