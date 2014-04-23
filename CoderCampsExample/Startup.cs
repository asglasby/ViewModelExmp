using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoderCampsExample.Startup))]
namespace CoderCampsExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
