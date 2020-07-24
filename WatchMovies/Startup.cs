using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatchMovies.Startup))]
namespace WatchMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
