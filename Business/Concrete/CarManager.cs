﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car c)
        {
            if(c.Description.Length >= 2)
            {
                if(c.DailyPrice > 0)
                {
                    _carDal.Add(c);
                    return new SuccessResult(Messages.CarAdded);
                }
            }

            return new ErrorResult(Messages.CarNotAdded);
        }

        public IResult Delete(Car c)
        {
            _carDal.Delete(c);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            // İŞ KODLARI

            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetAllDetailsOfCar()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllDetailsOfCar());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car c)
        {
            _carDal.Update(c);

            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
