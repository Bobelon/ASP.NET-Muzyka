using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMusic.Startup))]
namespace MvcMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
