using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieLessAppWithAuth.Startup))]
namespace CookieLessAppWithAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
