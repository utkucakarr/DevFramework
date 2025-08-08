using DevFramework.Northwind.Entities.Concerete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
        }
    }
}
