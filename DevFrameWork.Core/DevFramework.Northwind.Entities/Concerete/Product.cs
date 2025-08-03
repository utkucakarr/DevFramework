using DevFrameWork.Core.Entities;

namespace DevFramework.Northwind.Entities.Concerete
{
    public class Product : IEntity
    {
        public virtual int ProductID { get; set; }

        public virtual int CategoryID { get; set; }

        public virtual string ProductName { get; set; }

        public virtual decimal UnitPrice { get; set; }

        public virtual string QuantityPerUnit { get; set; }
    }
}
