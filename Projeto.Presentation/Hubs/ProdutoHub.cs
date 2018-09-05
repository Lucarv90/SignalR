using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Projeto.Presentation.Models;


namespace Projeto.Presentation.Hubs
{
    public class ProdutoHub : Hub
    {

        //método para notificar as demais páginas de que um cadastro foi realizado
        public void NotificacaoDeCadastro(ProdutoCadastroModel model)
        {
            //método executado pela página de consulta
            Clients.All.ObterDados(model);
        }
    }
}