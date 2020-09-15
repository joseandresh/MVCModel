using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admMVCModel.Startup))]
namespace admMVCModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
