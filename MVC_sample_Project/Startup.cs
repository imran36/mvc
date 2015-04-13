using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_sample_Project.Startup))]
namespace MVC_sample_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
