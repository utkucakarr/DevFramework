using DevFramework.Northwind.Entities.Concerete;
using System.Collections.Generic;
using System.ServiceModel;

namespace DevFramework.Northwind.Business.ServiceContract.WCF
{
    [ServiceContract]
    public interface IProductDetailService
    {
        [OperationContract]
        List<Product> GetAll();
    }
}