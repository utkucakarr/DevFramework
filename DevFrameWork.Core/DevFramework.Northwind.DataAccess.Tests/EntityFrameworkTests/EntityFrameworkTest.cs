using DevFramework.Northwind.DataAccess.Concerete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_product()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList();

            Assert.AreEqual(86, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_return_filtered_products()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(6, result.Count);
        }
    }
}
