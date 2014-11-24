using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudWebProject.Startup))]
namespace CrudWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
