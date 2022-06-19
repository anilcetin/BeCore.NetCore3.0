using Business.Abstract;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KnowledgeManager : IKnowledgeService
    {
        public IResult Add(Entities.Concrete.Knowledge knowledge)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Entities.Concrete.Knowledge knowledge)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Entities.Concrete.Knowledge> GetById(int knowledgeId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Entities.Concrete.Knowledge>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Entities.Concrete.Knowledge knowledge)
        {
            throw new System.NotImplementedException();
        }
    }
}
