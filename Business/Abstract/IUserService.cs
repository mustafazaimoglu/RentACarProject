using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User u);
        IResult Delete(User u);
        IResult Update(User u);
        IDataResult<List<OperationClaim>> GetClaims(User u);
        IDataResult<User> GetByMail(string email);
    }
}
