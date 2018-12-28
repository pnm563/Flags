using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flags.Startup))]
namespace Flags
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
