using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file,CarImage ci);
        IResult Delete(CarImage ci);
        IResult Update(IFormFile file, CarImage ci);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllImagesByCarId(int carId);
        IDataResult<CarImage> GetImageById(int id);
    }
}
