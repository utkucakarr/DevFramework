using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess.EntityFramework;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework
{
    public class EfRoleDal : EfEntityRepositoryBase<Role, NorthwindContext>, IRoleDal
    {
    }
}
