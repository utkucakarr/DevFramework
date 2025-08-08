using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess;
using System.Collections.Generic;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
