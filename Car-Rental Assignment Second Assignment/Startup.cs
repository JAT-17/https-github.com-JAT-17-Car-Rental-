using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_Rental_Assignment_Second_Assignment.Startup))]
namespace Car_Rental_Assignment_Second_Assignment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
