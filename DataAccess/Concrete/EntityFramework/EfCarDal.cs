﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetAllDetailsOfCar()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.ToList();
            }

        }

        public List<CarDetailDto> GetCarsByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             where car.BrandId == brandId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.ToList();
            }
        }

        public CarDetailDto GetCarByCarId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             where car.Id == id
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.Single();
            }
        }

        public List<CarDetailDto> GetCarsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             where car.ColorId == colorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarsByColorIdAndBrandId(int brandId, int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             where car.BrandId == brandId && car.ColorId == colorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.ToList();
            }
        }

        public CarDetailDto GetCar(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars where car.Id == id
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };

                return result.Single();
            }
        }
    }
}
