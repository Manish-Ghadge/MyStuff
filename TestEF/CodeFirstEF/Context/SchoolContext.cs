using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstEF.Model;

namespace CodeFirstEF.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=TestDbEntities") {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
