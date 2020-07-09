using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentBrief.Startup))]
namespace AssignmentBrief
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
