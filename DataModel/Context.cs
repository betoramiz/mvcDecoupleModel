using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
    public class Context : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Departamen> departaments { get; set; }

        public Context() : base("name=dbConnection") { }
    }
}
