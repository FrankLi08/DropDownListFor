using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDownListFor.Startup))]
namespace DropDownListFor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
