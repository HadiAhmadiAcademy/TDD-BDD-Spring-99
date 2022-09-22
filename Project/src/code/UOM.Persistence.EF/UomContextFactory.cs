using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UOM.Persistence.EF
{
    public static class UomContextFactory
    {
        public static UomContext Create(DbConnection connection)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer(connection);
            return new UomContext(builder.Options);
        }
    }
}