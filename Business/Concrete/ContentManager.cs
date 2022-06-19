using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContentManager : IContentService
    {
        public IResult Add(Content content)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Content content)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Content> GetById(int contentId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Content>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Content content)
        {
            throw new System.NotImplementedException();
        }
    }
}
