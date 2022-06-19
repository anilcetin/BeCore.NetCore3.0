using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITitleService
    {
        IDataResult<Title> GetById(int titleId);
        IDataResult<List<Title>> GetList();
        IResult Add(Title title);
        IResult Delete(Title title);
        IResult Update(Title title);
    }
}
