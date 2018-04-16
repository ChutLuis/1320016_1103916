using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab4_1103916_1320016.Startup))]
namespace Lab4_1103916_1320016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
