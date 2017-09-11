using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoApp.Startup))]
namespace VideoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
