using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationForCITesting.Startup))]
namespace ApplicationForCITesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
