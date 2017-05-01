using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShiftPerformance.Startup))]
namespace ShiftPerformance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
