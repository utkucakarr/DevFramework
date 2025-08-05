using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Constants;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.Aspects.Autofac.Validation;
using DevFrameWork.Core.Utilities.Results;
using System.Collections.Generic;
using System.Transactions;

namespace DevFramework.Northwind.Business.Concerete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<Product> Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessDataResult<Product>(product, Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(), Messages.ProductsListed);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == id));
        }

        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            // Business Codes
            _productDal.Update(product2);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<Product> Update(Product product)
        {
            return new SuccessDataResult<Product>(product, Messages.ProductAdded);
        }
    }
}