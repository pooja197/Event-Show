using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventShowWeb.Startup))]
namespace EventShowWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
