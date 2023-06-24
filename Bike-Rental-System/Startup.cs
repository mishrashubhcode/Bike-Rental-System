using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bike_Rental_System.Startup))]
namespace Bike_Rental_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
