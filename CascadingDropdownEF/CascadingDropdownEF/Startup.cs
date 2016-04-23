using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CascadingDropdownEF.Startup))]
namespace CascadingDropdownEF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
