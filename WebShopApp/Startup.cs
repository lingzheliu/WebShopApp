using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShopApp.Startup))]
namespace WebShopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
