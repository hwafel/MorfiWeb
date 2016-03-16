using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Morfi.Startup))]
namespace Morfi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
