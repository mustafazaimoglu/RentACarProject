using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer()
        {

        }
        public Customer(int userId, string companyName)
        {
            UserId = userId;
            CompanyName = companyName;
        }

        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
