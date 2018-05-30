using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSCeComm.Startup))]
namespace WSCeComm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
