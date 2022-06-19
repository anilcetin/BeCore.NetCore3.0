using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISocialService
    {
        IDataResult<Social> GetById(int socialId);
        IDataResult<List<Social>> GetList();
        IResult Add(Social social);
        IResult Delete(Social social);
        IResult Update(Social social);
    }
}
