using DevFrameWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevFrameWork.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<Tentity> : IEntityRepository<Tentity>
        where Tentity : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;

        public NhEntityRepositoryBase(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public Tentity Add(Tentity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(Tentity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetList(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter == null ? session.Query<Tentity>().ToList()
                    : session.Query<Tentity>().Where(filter).ToList();
            }
        }

        public Tentity Update(Tentity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
