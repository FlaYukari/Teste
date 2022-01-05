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
    public class PessoaDBContext : DbContext
    {
        public PessoaDBContext() : base("Name=PessoaDB")
        {
            Database.SetInitializer<PessoaDBContext>(
                new CreateDatabaseIfNotExists<PessoaDBContext>());
            Database.Initialize(false);//executa uma vez
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
