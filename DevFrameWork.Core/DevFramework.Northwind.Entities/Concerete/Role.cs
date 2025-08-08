using DevFrameWork.Core.Entities;

namespace DevFramework.Northwind.Entities.Concerete
{
    public class Role : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}