using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HexInfoManager : IHexInfoService
    {
        private IHexInfoDal _hexInfoDal;

        public HexInfoManager(IHexInfoDal hexInfoDal)
        {
            _hexInfoDal = hexInfoDal;
        }


        public IResult Add(HexInfo hexInfo)
        {
            _hexInfoDal.Add(hexInfo);
            return new SuccessResult(Messages.ReasonAdded);
        }
    }
}
