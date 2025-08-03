using DevFramework.Northwind.Entities.Concerete;
using FluentNHibernate.Conventions.Helpers;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Category", @"dbo");
            HasKey(x => x.CategoryID);

            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}
