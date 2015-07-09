using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocietyAnalysisWeb_v3.Startup))]
namespace SocietyAnalysisWeb_v3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
