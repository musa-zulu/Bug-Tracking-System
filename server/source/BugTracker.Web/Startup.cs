using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugTracker.Web.Startup))]
namespace BugTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
