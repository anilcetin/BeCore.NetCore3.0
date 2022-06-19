using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        IDataResult<Experience> GetById(int experienceId);
        IDataResult<List<Title>> GetList();
        IResult Add(Experience experience);
        IResult Delete(Experience experience);
        IResult Update(Experience experience);
    }
}
