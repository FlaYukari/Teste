using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TesteDbContext : DbContext
    {
        public TesteDbContext() : base("Name=TesteDb")
        {
            Database.SetInitializer<TesteDbContext>(
                new CreateDatabaseIfNotExist<TesteDbContext>()
                );
        }
    }

}
