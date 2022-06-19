using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SocialManager : ISocialService
    {
        public IResult Add(Social social)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Social social)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Social> GetById(int socialId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Social>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Social social)
        {
            throw new System.NotImplementedException();
        }
    }
}
