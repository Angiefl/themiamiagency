using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(themiamiagency.Startup))]
namespace themiamiagency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
