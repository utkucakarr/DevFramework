using AutoMapper;
using DevFramework.Northwind.Entities.Concerete;

namespace DevFramework.Northwind.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}
