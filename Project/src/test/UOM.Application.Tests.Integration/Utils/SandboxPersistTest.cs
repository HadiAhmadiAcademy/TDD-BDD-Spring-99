using System;
using System.ComponentModel.Design;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UOM.Persistence.EF;

namespace UOM.Application.Tests.Integration
{
    public class SandboxPersistTest : IDisposable
    {
        protected UomContext DbContext;
        public SandboxPersistTest()
        {
            var connectionString = RandomConnectionString(Constants.ConnectionString);
            DbContext = UomContextFactory.Create(new SqlConnection(connectionString));
            MigrateDatabaseToLatestVersion(DbContext);
        }
        public void Dispose()
        {
            DbContext.Dispose();
            //DROP SANDBOX DATABASE
        }
        private string RandomConnectionString(string baseConnection)
        {
            var builder = new SqlConnectionStringBuilder(baseConnection);
            builder.InitialCatalog = $"{builder.InitialCatalog}-{Guid.NewGuid():N}";
            return builder.ConnectionString;
        }
        private void MigrateDatabaseToLatestVersion(UomContext dbContext)
        {
            dbContext.Database.Migrate();
        }
    }
}