using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lands.backend.Startup))]
namespace Lands.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
