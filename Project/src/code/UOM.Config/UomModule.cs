using System.Data;
using System.Data.Common;
using System.Reflection;
using Autofac;
using Microsoft.Data.SqlClient;
using UOM.Application;
using UOM.Application.Contracts;
using UOM.Config.ConnectionManagement;
using UOM.Domain.Model.Dimensions;
using UOM.Persistence.EF;
using UOM.Persistence.EF.Repositories;
using UOM.RestApi;
using Module = Autofac.Module;

namespace UOM.Config
{
    public class UomModule : Module
    {
        private readonly Config _config;
        public UomModule(Config config)
        {
            _config = config;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DimensionService>().As<IDimensionService>().InstancePerLifetimeScope();
            builder.RegisterType<DimensionRepository>().As<IDimensionRepository>().InstancePerLifetimeScope();
            builder.Register(CreateConnectionManager).InstancePerLifetimeScope();
            builder.Register(CreateConnection).InstancePerLifetimeScope();
            builder.Register(CreateDbContext).InstancePerLifetimeScope();
        }
        private IConnectionManager CreateConnectionManager(IComponentContext arg)
        {
            return new ConnectionManager(_config.ConnectionString);
        }
        private DbConnection CreateConnection(IComponentContext arg)
        {
            var manager = arg.Resolve<IConnectionManager>();
            return new SqlConnection(manager.GetConnectionString());
        }
        private UomContext CreateDbContext(IComponentContext arg)
        {
            var connection = arg.Resolve<DbConnection>();
            return UomContextFactory.Create(connection);
        }

        public static Assembly GetAssemblyOfRestApi()
        {
            return typeof(DimensionsController).Assembly;
        }
    }
}
