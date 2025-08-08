using DevFrameWork.Core.Entities;

namespace DevFramework.Northwind.Entities.Concerete
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}
