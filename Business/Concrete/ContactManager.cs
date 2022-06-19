using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        public IResult Add(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Contact>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Contact contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
