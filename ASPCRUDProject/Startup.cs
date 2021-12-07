using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDTEST.Startup))]
namespace CRUDTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}


