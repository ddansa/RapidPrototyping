using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KontkatWebbApp.Startup))]
namespace KontkatWebbApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
