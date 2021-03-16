using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _myCars;

        public InMemoryCarDal()
        {
            _myCars = new List<Car>()
            {
                new Car(){ Id = 1, BrandId = 1, ColorId = 1, ModelYear = 1997, DailyPrice = 210,Description = "MAZDA RX-7" },
                new Car(){ Id = 2, BrandId = 2, ColorId = 5, ModelYear = 2001, DailyPrice = 350,Description = "NISSAN SKYLINE R34" },
                new Car(){ Id = 3, BrandId = 1, ColorId = 4, ModelYear = 1995, DailyPrice = 250,Description = "HONDA NSX" },
                new Car(){ Id = 4, BrandId = 3, ColorId = 7, ModelYear = 2021, DailyPrice = 500,Description = "NISSAN R35 GTR" },
                new Car(){ Id = 5, BrandId = 8, ColorId = 9, ModelYear = 1997, DailyPrice = 350,Description = "TOYOTA SUPRA" },
            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Car car)
        {
            _myCars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _myCars.SingleOrDefault(m => m.Id == car.Id);

            _myCars.Remove(toDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailsOfCar()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> ReadAll()
        {
            return _myCars;
        }

        public List<Car> ReadAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car toUpdate = _myCars.SingleOrDefault(m => m.Id == car.Id);
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.ModelYear = car.ModelYear;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.Description = car.Description;
        }

        List<CarDetailDto> ICarDal.GetCarByCarId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
