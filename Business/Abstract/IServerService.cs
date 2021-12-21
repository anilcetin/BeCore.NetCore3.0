using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServerService
    {
        IDataResult<Server> GetById(int serverId);
        IDataResult<List<Server>> GetList();
        IResult Add(Server server);
        IResult Delete(Server server);
        IResult Update(Server server);
    }
}
