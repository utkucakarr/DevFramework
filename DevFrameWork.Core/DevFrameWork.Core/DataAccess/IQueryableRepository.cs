using DevFrameWork.Core.Entities;
using System.Linq;

namespace DevFrameWork.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
