using DevFramework.Northwind.DataAccess.Concerete.EntityFramework;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess.EntityFramework;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public class EfUserRoleDal : EfEntityRepositoryBase<UserRole, NorthwindContext>, IUserRoleDal
    {
    }
}
