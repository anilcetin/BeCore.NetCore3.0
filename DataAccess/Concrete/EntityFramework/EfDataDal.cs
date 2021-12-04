using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDataDal : EfEntityRepositoryBase<Data, HexFinderContext>, IDataDal
    {
        public List<GetDataDto> GetDataList(string hexId)
        {
            using (HexFinderContext context = new HexFinderContext())
            {
                var result = from d in context.Datas
                             join s in context.Servers
                                on d.ServerId equals s.Id
                             where d.HexId == hexId
                             select new GetDataDto
                             {
                                 HexId = d.HexId,
                                 DiscordId = d.DiscordId,
                                 ServerName = s.Name,
                                 ReasonName = d.ReasonId,
                                 ReasonDate = d.ReasonDate
                             };
                return result.ToList();
            }
        }
    }
}
