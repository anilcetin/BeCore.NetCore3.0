using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class DataManager : IDataService
    {
        private IDataDal _dataDal;

        public DataManager(IDataDal dataDal)
        {
            _dataDal = dataDal;
        }

        public IResult Add(Data data)
        {
            Data newData = data;
            if (data.ReasonDate == null)
            {
                newData = new Data
                {
                    Id = data.Id,
                    HexId = data.HexId,
                    DiscordId = data.DiscordId,
                    ReasonId = data.ReasonId,
                    ServerId = data.ServerId,
                    ReasonDate = DateTime.Today.ToString("dd.MM.yyyy")
                };
            }
            _dataDal.Add(newData);
            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Data data)
        {
            _dataDal.Delete(data);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IResult Update(Data data)
        {
            Data newData = data;
            if (data.ReasonDate == null)
            {
                newData = new Data
                {
                    Id = data.Id,
                    HexId = data.HexId,
                    DiscordId = data.DiscordId,
                    ReasonId = data.ReasonId,
                    ServerId = data.ServerId,
                    ReasonDate = DateTime.Today.ToString("dd.MM.yyyy")
                };
            }
            _dataDal.Update(newData);
            return new SuccessResult(Messages.DataUpdated);
        }

        public IDataResult<Data> GetById(int dataId)
        {
            return new SuccessDataResult<Data>(_dataDal.Get(p => p.Id == dataId));
        }

        public IDataResult<List<Data>> GetList()
        {
            return new SuccessDataResult<List<Data>>(_dataDal.GetList().ToList());
        }

        public IDataResult<List<Data>> GetByHexId(string hexId)
        {
            return new SuccessDataResult<List<Data>>(_dataDal.GetList(p => p.HexId == hexId).ToList(), "Data listelendi");
        }
    }
}
