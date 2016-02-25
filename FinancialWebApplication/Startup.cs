using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinancialWebApplication.Startup))]
namespace FinancialWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
