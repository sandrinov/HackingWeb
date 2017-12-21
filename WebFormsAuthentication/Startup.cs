using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsAuthentication.Startup))]
namespace WebFormsAuthentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
