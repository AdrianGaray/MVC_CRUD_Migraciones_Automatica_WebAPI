using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CRUD_Migraciones_Automatica_WebAPI.Startup))]
namespace MVC_CRUD_Migraciones_Automatica_WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
