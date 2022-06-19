using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IDataResult<Education> GetById(int educationId);
        IDataResult<List<Education>> GetList();
        IResult Add(Education education);
        IResult Delete(Education education);
        IResult Update(Education education);
    }
}
