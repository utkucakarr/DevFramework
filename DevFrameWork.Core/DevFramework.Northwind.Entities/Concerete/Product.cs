using DevFrameWork.Core.Entities;

namespace DevFramework.Northwind.Entities.Concerete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string QuantityPerUnit { get; set; }
    }
}
