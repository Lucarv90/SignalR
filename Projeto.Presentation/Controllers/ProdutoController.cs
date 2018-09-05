using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Models;
using Projeto.Entidades;
using Projeto.Repository.Repositories;

namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Produto/Consulta
        public ActionResult Consulta()
        {
            return View();
        }


        //método request ajax do jquery
        public JsonResult CadastrarProduto(ProdutoCadastroModel model)
        {
            try
            {
                Produto p = new Produto();
                p.Nome = model.Nome;
                p.Preco = model.Preco;
                p.Quantidade = model.Quantidade;


                ProdutoRepository rep = new ProdutoRepository();
                rep.Insert(p);

                return Json($"Produto {p.Nome}, cadastrado com sucesso.");

            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        //método de exibição dos dados em gráfico

        public JsonResult ConsultarProdutos()
        {
            try
            {
                List<ProdutoConsultaModel> lista = new List<ProdutoConsultaModel>();

                ProdutoRepository rep = new ProdutoRepository();
                foreach(Produto p in rep.FindAll())
                {
                    ProdutoConsultaModel model = new ProdutoConsultaModel();
                    model.Nome = p.Nome;
                    model.Preco = p.Preco;

                    lista.Add(model);
                
                }
                return Json(lista);

            }
            catch(Exception e)
            {
                return Json(e.Message);

            }
        }




    }
}