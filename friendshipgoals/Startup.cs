using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(friendshipgoals.Startup))]
namespace friendshipgoals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
