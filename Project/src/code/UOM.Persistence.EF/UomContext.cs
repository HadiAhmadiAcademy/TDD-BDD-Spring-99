using System;
using Microsoft.EntityFrameworkCore;
using UOM.Domain.Model.Dimensions;

namespace UOM.Persistence.EF
{
    public class UomContext : DbContext
    {
        public DbSet<Dimension> Dimensions { get; set; }
        public UomContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UomContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
