using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAngularJS.Startup))]
namespace MVCAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
