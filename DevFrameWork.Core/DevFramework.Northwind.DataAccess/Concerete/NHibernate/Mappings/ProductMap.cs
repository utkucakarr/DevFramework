using DevFramework.Northwind.Entities.Concerete;
using FluentNHibernate.Mapping;

namespace DevFramework.Northwind.DataAccess.Concerete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            // Mapping
            Table("Products");
            LazyLoad();
            Id(x => x.ProductID).Column("ProductID");
            Map(x => x.CategoryID).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
        }
    }
}