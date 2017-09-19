using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trip_app.Startup))]
namespace trip_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
