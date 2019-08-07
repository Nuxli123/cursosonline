using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursosOnline.Web.Startup))]
namespace CursosOnline.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
