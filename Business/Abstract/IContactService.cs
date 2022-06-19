using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<Contact> GetById(int contactId);
        IDataResult<List<Contact>> GetList();
        IResult Add(Contact contact);
        IResult Delete(Contact contact);
        IResult Update(Contact contact);
    }
}
