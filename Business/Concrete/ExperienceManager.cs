using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        public IResult Add(Experience experience)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Experience experience)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Experience> GetById(int experienceId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Title>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Experience experience)
        {
            throw new System.NotImplementedException();
        }
    }
}
