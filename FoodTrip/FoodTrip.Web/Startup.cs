using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodTrip.Web.Startup))]
namespace FoodTrip.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
