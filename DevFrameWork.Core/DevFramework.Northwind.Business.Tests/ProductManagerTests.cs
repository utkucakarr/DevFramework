using DevFramework.Northwind.Business.Concerete;
using DevFramework.Northwind.Business.Constants;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ProductValidator))]
        [TestMethod]
        public void Product_validation_check()
        {
            //Arrange
            var mockProductDal = new Mock<IProductDal>();
            var productManager = new ProductManager(mockProductDal.Object);


            var product = new Product
            {
                ProductID = 1,
                CategoryID = 1,
                ProductName = "Aest Product",
                UnitPrice = 100,
                QuantityPerUnit = "10 boxes",
            };

            // Act
            var result = productManager.Add(product);

            // Assert
            mockProductDal.Verify(dal => dal.Add(product), Times.Once);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(Messages.ProductAdded, result.Message);
            Assert.AreEqual(product, result.Data);
        }
    }
}
