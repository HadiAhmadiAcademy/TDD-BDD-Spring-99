using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UOM.Persistence.EF
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<UomContext>
    {
        public UomContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder();
            options.UseSqlServer("data source=.;initial catalog=UOM-DB;Integrated security=true"); //TODO: read from args
            return new UomContext(options.Options);
        }
    }
}