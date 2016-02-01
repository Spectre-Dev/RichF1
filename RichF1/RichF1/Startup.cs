using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RichF1.Startup))]
namespace RichF1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
