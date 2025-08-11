using AutoMapper;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.Aspects.Postsharp.AuthorizationAspects;
using DevFrameWork.Core.Aspects.Postsharp.CacheAspects;
using DevFrameWork.Core.Aspects.Postsharp.PerformanceAspects;
using DevFrameWork.Core.Aspects.Postsharp.TransactionAspects;
using DevFrameWork.Core.Aspects.Postsharp.ValidationAspects;
using DevFrameWork.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFrameWork.Core.Utilities.Mappings;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DevFramework.Northwind.Business.Concerete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
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
        [PerformanceCounterAspect(2)] // Performans ölçümü 2 saniye
        //[SecuredOperation(Roles = "Admin, Editor, Student")]
        public List<Product> GetAll()
        {
            //Thread.Sleep(3000);
            //Manual mapping
            //return _productDal.GetList().Select(p => new Product
            //{
            //    ProductID = p.ProductID,
            //    CategoryID = p.CategoryID,
            //    ProductName = p.ProductName,
            //    QuantityPerUnit = p.QuantityPerUnit,
            //    UnitPrice = p.UnitPrice
            //}).ToList();

            // AutoMapper
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
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