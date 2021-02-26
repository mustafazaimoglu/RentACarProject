using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage ci);
        IResult Delete(CarImage ci);
        IResult Update(CarImage ci);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
    }
}
