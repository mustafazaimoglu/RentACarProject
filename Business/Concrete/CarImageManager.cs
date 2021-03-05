using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file,CarImage ci)
        {
            var result = BusinessRules.Run(CheckIfImageLimitExceded(ci.CarId));

            if (result.Count > 0)
            {
                return new ErrorDataResult<List<IResult>>(result);
            }

            string finalPath = ImageHelper.UploadImage(file);

            //string path = ImageHelper.MainPath();
            //string newGuidPath;

            //if (file != null)
            //{
            //    newGuidPath = ImageHelper.UploadImage(file, path);
            //}
            //else
            //{
            //    newGuidPath = "default.png";
            //}

            ci.Date = DateTime.Now;
            ci.ImagePath = finalPath;
            _carImageDal.Add(ci);

            return new SuccessResult();
        }

        public IResult Delete(CarImage ci)
        {
            _carImageDal.Delete(ci);
            ImageHelper.DeleteImage(ci.ImagePath);

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
        }

        public IDataResult<CarImage> GetImageById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IResult Update(IFormFile file, CarImage ci)
        {
            string finalPath = ImageHelper.UploadImage(file);
            ImageHelper.DeleteImage(ci.ImagePath);

            ci.Date = DateTime.Now;
            ci.ImagePath = finalPath;
            _carImageDal.Update(ci);

            return new SuccessResult();
        }

        private IResult CheckIfImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == carId);

            if(result.Count > 5)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }

            return new SuccessResult(Messages.ImageHasBeenAddedSuccessfully);
        }


    }
}
