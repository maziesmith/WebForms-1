using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamSkeleton.Startup))]
namespace ExamSkeleton
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
