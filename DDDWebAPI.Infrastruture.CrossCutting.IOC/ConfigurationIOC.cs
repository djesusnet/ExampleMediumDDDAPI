using Autofac;
using DDDWebAPI.Application.Interfaces;
using DDDWebAPI.Application.Service;
using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Domain.Services.Services;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map;
using DDDWebAPI.Infrastruture.Repository.Repositorys;

namespace DDDWebAPI.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<IServiceProduto>().As<IServiceProduto>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion

        }
    }
}
