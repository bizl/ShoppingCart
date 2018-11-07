using Owin;
using System.Web.Http;

namespace MyCompany.Cart.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Map("/api", api =>
            {
                var config = new HttpConfiguration();
                config.MapHttpAttributeRoutes();
                api.UseWebApi(config);
            });

            appBuilder.UseNancy();
        }
    }
}
