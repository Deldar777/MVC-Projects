using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shekho.Startup))]
namespace Shekho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
