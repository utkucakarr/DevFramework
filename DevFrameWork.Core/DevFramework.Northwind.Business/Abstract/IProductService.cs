using DevFramework.Northwind.Entities.Concerete;
using System.Collections.Generic;
using System.ServiceModel;

namespace DevFramework.Northwind.Business.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();
        
        [OperationContract]
        Product GetById(int id);

        [OperationContract]
        Product Add(Product product);

        [OperationContract]
        Product Update(Product product);

        [OperationContract]
        void Delete(Product product);

        [OperationContract]
        void TransactionalOperation(Product product1, Product product2);
    }
}