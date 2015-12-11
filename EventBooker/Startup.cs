using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventBooker.Startup))]
namespace EventBooker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
