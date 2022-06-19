using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        public IResult Add(Portfolio portfolio)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Portfolio portfolio)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Portfolio> GetById(int portfolioId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Portfolio>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Portfolio portfolio)
        {
            throw new System.NotImplementedException();
        }
    }
}
