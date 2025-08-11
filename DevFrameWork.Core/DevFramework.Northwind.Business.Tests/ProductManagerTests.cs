using AutoMapper;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concerete.Managers;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        private IMapper _mapper = InstanceFactory.GetInstance<IMapper>();
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object, _mapper);

            Assert.ThrowsException<ValidationException>(() =>
            {
                productManager.Add(new Product());
            });
        }
    }
}
