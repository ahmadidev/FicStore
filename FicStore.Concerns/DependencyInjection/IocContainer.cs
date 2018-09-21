using Autofac;
using FicStore.Business.Queries.GetAllCategories;
using FicStore.Data;
using FicStore.Persistence;

namespace FicStore.Concerns.DependencyInjection
{
    public class IocContainer
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            //Business
            var businessAssembly = typeof(GetAllCategoriesQuery).Assembly;

            builder.RegisterAssemblyTypes(businessAssembly)
                .Where(x => x.Name.EndsWith("Query"))
                .AsSelf()
                .InstancePerRequest();

            //Data
            builder.RegisterType<AppDbContext>()
                .AsSelf()
                .InstancePerRequest();

            //Persistence
            var persistenceAssembly = typeof(CategoryRepository).Assembly;

            builder.RegisterAssemblyTypes(persistenceAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}
