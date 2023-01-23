using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(Guid product);
        IDataResult<List<Product>> GetList();
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
