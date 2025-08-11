using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.Business.ServiceContract.WCF;
using DevFramework.Northwind.Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService : IProductDetailService
{
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}