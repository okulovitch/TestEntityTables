using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace kursachMain.Models
{
    class GrupsContext:DbContext
    {
        public GrupsContext() : base("DefaultConnection")
        {

        }
        public DbSet<Grups> Grup { get; set; }
    }
}
