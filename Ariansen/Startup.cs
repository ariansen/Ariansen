using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ariansen.Startup))]
namespace Ariansen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
