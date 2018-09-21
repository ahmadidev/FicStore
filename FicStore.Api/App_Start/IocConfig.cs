using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using FicStore.Concerns.DependencyInjection;

namespace FicStore.Api
{
    public class IocConfig
    {
        public static void Config(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            IocContainer.RegisterTypes(builder);

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
