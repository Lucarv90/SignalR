using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades;
using Projeto.Repository.Context;

namespace Projeto.Repository.Repositories
{
    public class ProdutoRepository
    {
        public void Insert(Produto p)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(p).State = EntityState.Added;
                d.SaveChanges();
            }
        }
        public void Update(Produto p)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(p).State = EntityState.Modified;
                d.SaveChanges();
            }
        }

        public void Delete(Produto p)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(p).State = EntityState.Deleted;
                d.SaveChanges();
            }
        }


        public List<Produto> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Produto.ToList();
            }
        }

        public Produto FindById(int id)
        {
            using (DataContext d = new DataContext())
            {
                return d.Produto.Find(id);
            }
        }

    }
}
