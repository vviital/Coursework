using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SocietyAnalysisWeb.DataModel;

namespace Services.Support
{
    //public class TypeConverter : ITypeConverter<BaseEntity, int>
    //{
    //    public int Convert(ResolutionContext context)
    //    {
    //        BaseEntity entity = (BaseEntity) context.SourceValue;
    //        return entity.Id;
    //    }
    //}
    public class EntityConverter : ITypeConverter<int, BaseEntity>
    {
        public BaseEntity Convert(ResolutionContext context)
        {
            return new BaseEntity();
        }
    }
}
