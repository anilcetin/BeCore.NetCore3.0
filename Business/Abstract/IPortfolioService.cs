using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPortfolioService
    {
        IDataResult<Portfolio> GetById(int portfolioId);
        IDataResult<List<Portfolio>> GetList();
        IResult Add(Portfolio portfolio);
        IResult Delete(Portfolio portfolio);
        IResult Update(Portfolio portfolio);
    }
}
