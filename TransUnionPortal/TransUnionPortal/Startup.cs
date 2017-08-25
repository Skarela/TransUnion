using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TransUnionPortal.Startup))]
namespace TransUnionPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
