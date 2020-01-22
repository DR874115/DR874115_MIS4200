using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DR874115_MIS4200.Startup))]
namespace DR874115_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
