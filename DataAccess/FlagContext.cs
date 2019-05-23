using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;

namespace DataAccess
{
    public class FlagContext : DbContext
    {
        public DbSet<Flag> Flag { get; set; }
        public DbSet<Question> Question { get; set; }
    }
}
