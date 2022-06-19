using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        public IResult Add(Education education)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Education education)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Education> GetById(int educationId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Education>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Education education)
        {
            throw new System.NotImplementedException();
        }
    }
}
