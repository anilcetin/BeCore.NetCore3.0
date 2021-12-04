using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDataDal : IEntityRepository<Data>
    {
        List<GetDataDto> GetDataList(string hexId);
    }
}
