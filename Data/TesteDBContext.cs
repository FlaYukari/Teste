using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TesteDBContext : DbContext
    {
        public TesteDBContext() : base("Name=TesteDB")
        {
            Database.SetInitializer<TesteDBContext>(
                new CreateDatabaseIfNotExists<TesteDBContext>());
            Database.Initialize(false);//executa uma vez
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
