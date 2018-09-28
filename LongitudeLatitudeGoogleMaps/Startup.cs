using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LongitudeLatitudeGoogleMaps.Startup))]
namespace LongitudeLatitudeGoogleMaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
