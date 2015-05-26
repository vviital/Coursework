using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocietyAnalysisWeb_v1.Startup))]
namespace SocietyAnalysisWeb_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
