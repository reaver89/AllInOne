using Microsoft.Owin;
using Owin;
using PostReaderWebUI;

[assembly: OwinStartup(typeof(Startup))]
namespace PostReaderWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
