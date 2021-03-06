﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car c);
        IResult Delete(Car c);
        IResult Update(Car c);
        IResult GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<CarDetailDto> GetCar(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        IDataResult<CarDetailDto> GetCarByCarId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorIdAndBrandId(int brandId, int colorId);
        IResult GetAllDetailsOfCar();

    }
}
