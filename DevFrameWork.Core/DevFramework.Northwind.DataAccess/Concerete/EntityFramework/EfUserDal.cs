using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concerete;
using DevFrameWork.Core.DataAccess.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace DevFramework.Northwind.DataAccess.Concerete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.UserId equals user.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem
                             {
                                 RoleName = r.Name
                             };
                return result.ToList();
            }
        }
    }
}