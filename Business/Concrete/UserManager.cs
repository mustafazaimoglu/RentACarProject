using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User u)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(u));
        }

        public IResult Update(User u)
        {
            _userDal.Update(u);

            return new SuccessResult();
        }
    }
}
