using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User u)
        {
            //ValidationTool.Validate(new UserValidator(), u);

            _userDal.Add(u);
            return new SuccessResult();
        }

        public IResult Delete(User u)
        {
            _userDal.Delete(u);

            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IResult Update(User u)
        {
            _userDal.Update(u);

            return new SuccessResult();
        }
    }
}
