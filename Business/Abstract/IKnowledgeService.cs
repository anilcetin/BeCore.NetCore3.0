using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKnowledgeService
    {
        IDataResult<Knowledge> GetById(int knowledgeId);
        IDataResult<List<Knowledge>> GetList();
        IResult Add(Knowledge knowledge);
        IResult Delete(Knowledge knowledge);
        IResult Update(Knowledge knowledge);
    }
}
