using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RM.Presentation.UI.Startup))]
namespace RM.Presentation.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
