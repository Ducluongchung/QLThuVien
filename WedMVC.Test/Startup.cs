using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WedMVC.Test.Startup))]
namespace WedMVC.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
