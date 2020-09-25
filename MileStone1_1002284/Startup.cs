using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MileStone1_1002284.Startup))]
namespace MileStone1_1002284
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
