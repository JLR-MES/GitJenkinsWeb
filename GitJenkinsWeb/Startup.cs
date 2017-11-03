using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitJenkinsWeb.Startup))]
namespace GitJenkinsWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
