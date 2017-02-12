using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Console.log.Startup))]
namespace Console.log
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
