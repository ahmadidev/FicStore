using System.Web.Http;

namespace FicStore.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            IocConfig.Config(GlobalConfiguration.Configuration);
        }
    }
}
