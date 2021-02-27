using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public CarImage()
        {

        }

        public CarImage(int carId)
        {
            CarId = carId;
        }

        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
