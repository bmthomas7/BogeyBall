using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BogeyBall.WebMVC.Startup))]
namespace BogeyBall.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
