using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HairSalonApp.Startup))]
namespace HairSalonApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
