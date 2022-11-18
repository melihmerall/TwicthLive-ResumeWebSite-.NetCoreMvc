using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Business.Utilities.AutoMapper
{
    public class MapperUtil<TSource, TDestination>
    {
        private static Mapper _mapper = new Mapper(new MapperConfiguration(
            config => config.CreateMap<TSource, TDestination>()
                .ReverseMap()
        ));

        public static TDestination Map(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
