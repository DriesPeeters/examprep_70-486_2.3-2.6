using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(examprep_70_486.Startup))]
namespace examprep_70_486
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
