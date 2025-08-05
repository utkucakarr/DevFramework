using DevFramework.Northwind.Entities.Concerete;
using FluentNHibernate.Mapping;

namespace DevFramework.Northwind.DataAccess.Concerete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            // Mapping
            Table("Products");
            LazyLoad();
            Id(x => x.CategoryID).Column("CategoryID");

            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}