using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoccerUpdated.Startup))]
namespace SoccerUpdated
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
