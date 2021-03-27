using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color c)
        {
            if(c.ColorId > 1000)
            {
                return new ErrorResult();
            }

            _colorDal.Add(c);

            return new SuccessResult();
            
        }

        public IResult Delete(Color c)
        {
            _colorDal.Delete(c);

            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult Update(Color c)
        {
            _colorDal.Update(c);

            return new SuccessResult();
        }
    }
}
