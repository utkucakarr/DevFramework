using DevFramework.Northwind.DataAccess.Concerete.EntityFramework.Mapping;
using DevFramework.Northwind.Entities.Concerete;
using System.Data.Entity;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
