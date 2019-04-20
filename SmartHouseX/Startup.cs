using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartHouseX.Startup))]
namespace SmartHouseX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
