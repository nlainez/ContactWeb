using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConctWeb.Startup))]
namespace ConctWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
