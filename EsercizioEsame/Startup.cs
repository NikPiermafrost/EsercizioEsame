using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EsercizioEsame.Startup))]
namespace EsercizioEsame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
