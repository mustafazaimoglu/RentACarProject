using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public Brand()
        {

        }
        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
