using AutoMapper;
using System.Collections.Generic;

namespace DevFrameWork.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapsToSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<T, T>();
            });
            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }

        public static T MapToSameType<T>(T obj)
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<T, T>();
            });
            T result = Mapper.Map<T, T>(obj);
            return result;
        }
    }
}