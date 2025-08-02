using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
