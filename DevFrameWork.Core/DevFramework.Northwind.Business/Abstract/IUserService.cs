using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concerete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);

        List<UserRoleItem> GetUserRoles(User user);
    }
}
