using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wakency.Startup))]
namespace Wakency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
