using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amaradevops.Startup))]
namespace Amaradevops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
