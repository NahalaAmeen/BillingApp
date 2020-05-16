using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiilingWebApplication.Startup))]
namespace BiilingWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
