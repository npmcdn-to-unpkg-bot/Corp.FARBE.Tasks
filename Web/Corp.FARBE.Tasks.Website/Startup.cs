using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Corp.FARBE.Tasks.Website.Startup))]
namespace Corp.FARBE.Tasks.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
