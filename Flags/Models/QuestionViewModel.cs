using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flags.Models
{
    public class QuestionViewModel
    {
        public Guid ID { get; set; }
        public IEnumerable<Flag> FlagChoices { get; set; }
        public Guid UserAnswer { get; set; }
        public string QuestionText { get; set; }
    }
}