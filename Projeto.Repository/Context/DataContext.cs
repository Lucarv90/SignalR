using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using Projeto.Repository.Mappings;
using Projeto.Entidades;

namespace Projeto.Repository.Context
{
    public class DataContext : DbContext
    {


        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
        public DbSet<Produto> Produto { set; get; }
    }
}
