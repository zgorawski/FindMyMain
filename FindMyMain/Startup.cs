using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindMyMain.Startup))]
namespace FindMyMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
