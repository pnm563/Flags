using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Flag
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IndexNo { get; set; }
        public string ImageFile { get; set; }
        public FlagType FlagType {get; set;}
    }

    public enum FlagType
    {
        CountryFlag
    }

}
