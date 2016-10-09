using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SA120974.Startup))]
namespace SA120974
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
