using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISkillService
    {
        IDataResult<Skill> GetById(int skillId);
        IDataResult<List<Skill>> GetList();
        IResult Add(Skill skill);
        IResult Delete(Skill skill);
        IResult Update(Skill skill);
    }
}
