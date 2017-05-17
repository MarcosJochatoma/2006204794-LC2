using _2006204794_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_PER
{
    public class CajeroAutomaticoDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
