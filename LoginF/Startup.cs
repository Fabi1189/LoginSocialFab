using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginF.Startup))]
namespace LoginF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
