using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSDemo.Startup))]
namespace PSDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
