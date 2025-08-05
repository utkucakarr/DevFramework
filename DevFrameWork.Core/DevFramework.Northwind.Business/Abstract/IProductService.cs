using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.Utilities.Results;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<Product> GetById(int id);

        IDataResult<Product> Add(Product product);

        IDataResult<Product> Update(Product product);

        IResult Delete(Product product);

        void TransactionalOperation(Product product1, Product product2);
    }
}
