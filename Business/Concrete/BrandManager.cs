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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand b)
        {
            if(b.BrandName.Length < 2)
            {
                return new ErrorResult();
            }

            _brandDal.Add(b);

            return new SuccessResult();
        }


        public IResult Delete(Brand b)
        {
            _brandDal.Delete(b);

            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Update(Brand b)
        {
            _brandDal.Update(b);

            return new SuccessResult();
        }
    }
}
