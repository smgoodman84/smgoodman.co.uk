using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smgoodman.co.uk.Startup))]
namespace smgoodman.co.uk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
