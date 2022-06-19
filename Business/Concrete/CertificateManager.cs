using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CertificateManager : ICertificateService
    {
        private ICertificateDal _certificateDal;
        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public IResult Add(Certificate certificate)
        {
            _certificateDal.Add(certificate);
            return new SuccessResult(Messages.ServerAdded);
        }

        public IResult Delete(Certificate certificate)
        {
            _certificateDal.Delete(certificate);
            return new SuccessResult(Messages.ServerDeleted);
        }

        public IDataResult<Certificate> GetById(int certificateId)
        {
            return new SuccessDataResult<Certificate>(_certificateDal.Get(p => p.CertificateId == certificateId));
        }

        public IDataResult<List<Certificate>> GetList()
        {
            return new SuccessDataResult<List<Certificate>>(_certificateDal.GetList().ToList());
        }

        public IResult Update(Certificate certificate)
        {
            _certificateDal.Update(certificate);
            return new SuccessResult(Messages.ServerUpdated);
        }
    }
}
