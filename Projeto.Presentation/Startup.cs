using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Projeto.Presentation.Startup))]

namespace Projeto.Presentation
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //habilitar signalr

            app.MapSignalR();
        }
    }
}
