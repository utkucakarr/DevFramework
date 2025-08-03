using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess.NHibernate;

namespace DevFramework.Northwind.DataAccess.Concerete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
