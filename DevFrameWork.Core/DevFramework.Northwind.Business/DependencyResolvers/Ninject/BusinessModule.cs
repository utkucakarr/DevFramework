using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concerete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concerete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concerete.NHibernate.Helper;
using DevFrameWork.Core.DataAccess;
using DevFrameWork.Core.DataAccess.EntityFramework;
using DevFrameWork.Core.DataAccess.NHibernate;
using Ninject.Modules;
using System.Data.Entity;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();


            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
