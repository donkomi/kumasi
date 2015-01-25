using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kumasi.Web.Startup))]
namespace Kumasi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
