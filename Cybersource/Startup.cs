using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cybersource.Startup))]
namespace Cybersource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
