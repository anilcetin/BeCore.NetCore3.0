using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        public IResult Add(Skill skill)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Skill skill)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Skill> GetById(int skillId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Skill>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Skill skill)
        {
            throw new System.NotImplementedException();
        }
    }
}
