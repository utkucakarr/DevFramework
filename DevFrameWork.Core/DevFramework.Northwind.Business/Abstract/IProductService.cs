using DevFramework.Northwind.Entities.Concerete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        Product Add(Product product);

        Product Update(Product product);

        void Delete(Product product);

        void TransactionalOperation(Product product1, Product product2);
    }
}
