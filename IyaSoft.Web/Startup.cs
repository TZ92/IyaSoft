using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IyaSoft.Web.Startup))]
namespace IyaSoft.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
