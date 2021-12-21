using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDataService
    {
        IDataResult<Data> GetById(int dataId);
        IDataResult<List<Data>> GetList();
        IResult Add(Data data);
        IResult Delete(Data data);
        IResult Update(Data data);
        IDataResult<List<Data>> GetByHexId(string hexId);
    }
}
