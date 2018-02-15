using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LmycDataLib.Startup))]
namespace LmycDataLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
