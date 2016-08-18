using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureServiceBus.Web.Startup))]
namespace AzureServiceBus.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
             ConfigureAuth(app);
        }
    }
}
