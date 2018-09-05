using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.Repository.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {

        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey(p => p.IdProduto);

            Property(p => p.IdProduto)
                           .HasColumnName("IdProduto");

            Property(p => p.Nome)
                       .HasColumnName("Nome")
                       .HasMaxLength(50)
                       .IsRequired();


            Property(p => p.Preco)
                    .HasColumnName("Preco");




        }

    }
}
