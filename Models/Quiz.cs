using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Question
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public IEnumerable<Flag> FlagChoices { get; set; }
        public Guid AspNetUserID { get; set; }
        public Guid UserAnswer { get; set; }
        public Guid CorrectAnswer { get; set; }
        

    }


 
}
