using DevFramework.Northwind.DataAccess.Concerete.NHibernate;
using DevFramework.Northwind.DataAccess.Concerete.NHibernate.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.NhibernateTests
{
    [TestClass]
    public class NhibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList();

            Assert.AreEqual(86, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_return_filtered_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(6, result.Count);
        }
    }
}