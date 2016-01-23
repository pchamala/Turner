using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Turner.Startup))]
namespace Turner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
