using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetAllDetailsOfCar();
        List<CarDetailDto> GetCarsByBrandId(int id);
        List<CarDetailDto> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarByCarId(int id);
        List<CarDetailDto> GetCarsByColorIdAndBrandId(int brandId,int colorId);


    }
}
