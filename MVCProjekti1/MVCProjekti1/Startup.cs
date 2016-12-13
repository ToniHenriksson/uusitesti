using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjekti1.Startup))]
namespace MVCProjekti1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
