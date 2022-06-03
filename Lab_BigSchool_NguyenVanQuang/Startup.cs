using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_BigSchool_NguyenVanQuang.Startup))]
namespace Lab_BigSchool_NguyenVanQuang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
