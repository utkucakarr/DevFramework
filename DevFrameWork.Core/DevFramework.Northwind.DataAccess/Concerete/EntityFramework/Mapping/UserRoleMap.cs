using DevFramework.Northwind.Entities.Concerete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Manual Mapping
            ToTable(@"UserRoles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.RoleId).HasColumnName("RoleId");
        }
    }
}
