using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _certificateDal;
        public ProductManager(IProductDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public IResult Add(Product product)
        {
            _certificateDal.Add(product);
            return new SuccessResult(Messages.ServerAdded);
        }

        public IResult Delete(Product product)
        {
            _certificateDal.Delete(product);
            return new SuccessResult(Messages.ServerDeleted);
        }

        public IDataResult<Product> GetById(Guid productId)
        {
            return new SuccessDataResult<Product>(_certificateDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_certificateDal.GetList().ToList());
        }

        public IResult Update(Product product)
        {
            _certificateDal.Update(product);
            return new SuccessResult(Messages.ServerUpdated);
        }
    }
}
