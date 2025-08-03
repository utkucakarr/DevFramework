using DevFrameWork.Core.Entities;

namespace DevFramework.Northwind.Entities.Concerete
{
    public class Category : IEntity
    {
        public virtual int CategoryID { get; set; }

        public virtual string CategoryName { get; set; }
    }
}
