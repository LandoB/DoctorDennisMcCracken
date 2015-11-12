using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoctorDennisMcCracken.Startup))]
namespace DoctorDennisMcCracken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
