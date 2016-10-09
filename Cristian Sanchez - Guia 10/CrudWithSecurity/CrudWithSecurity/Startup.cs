using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudWithSecurity.Startup))]
namespace CrudWithSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
