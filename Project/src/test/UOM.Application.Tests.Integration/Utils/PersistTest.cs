using System;
using System.Transactions;
using Microsoft.Data.SqlClient;
using UOM.Persistence.EF;

namespace UOM.Application.Tests.Integration
{
    public abstract class PersistTest : IDisposable
    {
        private TransactionScope _scope;
        protected UomContext UomContext;
        protected PersistTest()
        {
            _scope = new TransactionScope();
            UomContext = UomContextFactory.Create(new SqlConnection(Constants.ConnectionString));
        }

        public void Dispose()
        {
            UomContext.Dispose();
            _scope.Dispose();
        }
    }
}