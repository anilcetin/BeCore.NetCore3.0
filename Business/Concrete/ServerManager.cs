using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ServerManager : IServerService
    {
        private IServerDal _serverDal;
        public ServerManager(IServerDal serverDal)
        {
            _serverDal = serverDal;
        }
        public IResult Add(Server reason)
        {
            IResult result = BusinessRules.Run(CheckIfServerNameExists(reason.Name));

            if (result != null)
            {
                return result;
            }
            _serverDal.Add(reason);
            return new SuccessResult(Messages.ServerAdded);
        }

        private IResult CheckIfServerNameExists(string serverName)
        {
            var result = _serverDal.GetList(p => p.Name == serverName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ReasonNameAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Server server)
        {
            _serverDal.Delete(server);
            return new SuccessResult(Messages.ServerDeleted);
        }

        public IDataResult<Server> GetById(string Id)
        {
            return new SuccessDataResult<Server>(_serverDal.Get(p => p.Id == Id));
        }

        public IDataResult<List<Server>> GetList()
        {
            return new SuccessDataResult<List<Server>>(_serverDal.GetList().ToList());
        }

        public IResult Update(Server server)
        {
            _serverDal.Update(server);
            return new SuccessResult(Messages.ServerUpdated);
        }
    }
}
