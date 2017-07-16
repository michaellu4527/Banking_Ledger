using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Banking_Project.Startup))]
namespace Banking_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
