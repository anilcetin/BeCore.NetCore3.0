using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICertificateService
    {
        IDataResult<Certificate> GetById(int certificateId);
        IDataResult<List<Certificate>> GetList();
        IResult Add(Certificate certificate);
        IResult Delete(Certificate certificate);
        IResult Update(Certificate certificate);
    }
}
