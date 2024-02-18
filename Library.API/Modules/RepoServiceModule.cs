using Autofac;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.Repository;
using Library.Repository.Repositories;
using Library.Repository.UnitOfWork;
using Library.ServiceBase.Mapping;
using Library.ServiceBase.Services;
using System.Reflection;
using Module = Autofac.Module;//moddule sınıfı reflection paketinde de olduğu için biz autofac paketindekini almasını belirttik
namespace Library.API.Modules
{   
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(RepositoryBase<>)).As(typeof(IRepositoryBase<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ServiceBase<>)).As(typeof(IServiceBase<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(LibraryDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile)); // MapProfile tipinin bulunduğu assembly'i alır.



            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope(); // Belirtilen assembly'lerdeki "Repository" ile biten tipleri bulur ve onları implemented interfaces olarak kaydeder.

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope(); // Belirtilen assembly'lerdeki "Service" ile biten tipleri bulur ve onları implemented interfaces olarak kaydeder.
        
        }
    } 
}