using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(si03481_webdev.Startup))]
namespace si03481_webdev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
