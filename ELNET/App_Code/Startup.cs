using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELNET.Startup))]
namespace ELNET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
