using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PierwszProjektWeb.Startup))]
namespace PierwszProjektWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
