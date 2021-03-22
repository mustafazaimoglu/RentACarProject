using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin,user")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("Get")]
        public IResult Add(Car c)
        {
            List<IResult> result = BusinessRules.Run(CheckMaintenanceTime());

            if (result.Count > 0)
            {
                return new ErrorDataResult<List<IResult>>(result);
            }

            _carDal.Add(c);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car c)
        {
            _carDal.Delete(c);

            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        //[PerformanceAspect(5)] // İnterceptors a eklendi
        public IResult GetAll()
        {
            // İŞ KODLARI

            List<IResult> result = BusinessRules.Run(CheckMaintenanceTime());

            if (result.Count > 0)
            {
                return new ErrorDataResult<List<IResult>>(result);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IResult GetAllDetailsOfCar()
        {
            List<IResult> result = BusinessRules.Run(CheckMaintenanceTime());

            if (result.Count > 0)
            {
                return new ErrorDataResult<List<IResult>>(result);
            }

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllDetailsOfCar());
        }

        [CacheAspect]
        //[PerformanceAspect(5)] interceptors a eklendi
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarByCarId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarByCarId(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByBrandId(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByColorId(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorIdAndBrandId(int brandId, int colorId)
        {
            var result = _carDal.GetCarsByColorIdAndBrandId(brandId, colorId);

            return new SuccessDataResult<List<CarDetailDto>>(result);
        }

        public IResult Update(Car c)
        {
            _carDal.Update(c);

            return new SuccessResult(Messages.CarUpdated);
        }

        private IResult CheckMaintenanceTime()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            return new SuccessResult();
        }

    }
}
