using DevFrameWork.Core.Entities;
using System.Linq;

namespace DevFrameWork.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHepler;
        private IQueryable<T> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHepler)
        {
            _nHibernateHepler = nHibernateHepler;
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHepler.OpenSession().Query<T>()); }
        }
    }
}
