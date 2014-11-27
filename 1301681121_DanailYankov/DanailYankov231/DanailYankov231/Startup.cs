using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanailYankov231.Startup))]
namespace DanailYankov231
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
