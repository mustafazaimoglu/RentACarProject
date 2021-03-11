using Business.Abstract;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental r)
        {
            int carId = r.CarId;

            List<Rental> list = _rentalDal.GetAll();
            DateTime returnDate = DateTime.Today.AddDays(-1); // Yesterday

            foreach (var item in list)
            {
                if(item.CarId == carId)
                {
                    returnDate = item.ReturnDate;
                }
            }

            if (returnDate > r.RentDate)
            {
                return new ErrorResult(Messages.CarRentTimeError);
            }

            _rentalDal.Add(r);

            return new SuccessResult();
        }

        public IResult Delete(Rental r)
        {
            _rentalDal.Delete(r);

            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id));
        }

        public IResult GetDetailedRental()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetailedRental());
        }

        public IResult Update(Rental r)
        {
            _rentalDal.Update(r);

            return new SuccessResult();
        }
    }
}
