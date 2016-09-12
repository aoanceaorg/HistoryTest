using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HistoryTest.Startup))]
namespace HistoryTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
