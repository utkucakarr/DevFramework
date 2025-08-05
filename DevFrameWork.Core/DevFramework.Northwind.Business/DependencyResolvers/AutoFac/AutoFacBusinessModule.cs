using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concerete;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concerete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concerete.NHibernate.Helper;
using DevFrameWork.Core.DataAccess;
using DevFrameWork.Core.DataAccess.EntityFramework;
using DevFrameWork.Core.DataAccess.NHibernate;
using DevFrameWork.Core.Utilities.Interceptors;
using System.Data.Entity;

namespace DevFramework.Northwind.Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // IProduct sevice isteyene ProductManager ver IoC yapılanması.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterGeneric(typeof(EfQueryableRepository<>)).As(typeof(IQueryableRepository<>));
            builder.RegisterType<NorthwindContext>().As<DbContext>();

            builder.RegisterType<SqlServerHelper>().As<NHibernateHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            // Autofact bütün sınıflarımız için aspect'i varmı diye bakıyor.
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}