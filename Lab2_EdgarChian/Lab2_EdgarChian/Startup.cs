using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_EdgarChian.Startup))]
namespace Lab2_EdgarChian
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
