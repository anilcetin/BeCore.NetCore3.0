using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TitleManager : ITitleService
    {
        public IResult Add(Title title)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Title title)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Title> GetById(int titleId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Title>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Title title)
        {
            throw new System.NotImplementedException();
        }
    }
}
