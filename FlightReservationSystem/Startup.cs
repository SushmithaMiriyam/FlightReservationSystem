using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightReservationSystem.Startup))]
namespace FlightReservationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
