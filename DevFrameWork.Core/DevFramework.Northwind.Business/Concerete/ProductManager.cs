using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.Aspects.Postsharp.CacheAspects;
using DevFrameWork.Core.Aspects.Postsharp.LogAspects;
using DevFrameWork.Core.Aspects.Postsharp.TransactionAspects;
using DevFrameWork.Core.Aspects.Postsharp.ValidationAspects;
using DevFrameWork.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFrameWork.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Concerete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))] // cache clear
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            //Business code
            _productDal.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}