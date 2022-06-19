using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContentService
    {
        IDataResult<Content> GetById(int contentId);
        IDataResult<List<Content>> GetList();
        IResult Add(Content content);
        IResult Delete(Content content);
        IResult Update(Content content);
    }
}
