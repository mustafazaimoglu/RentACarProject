using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // MKZ
            CarTest();

            Console.WriteLine("\n");

            ColorTest();
            
            Console.WriteLine("\n");

            BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var b in brandManager.GetAll().Data)
            {
                Console.WriteLine(b.BrandId + " " + b.BrandName);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Update(new Color(8, "Pink"));

            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " " + c.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine(carManager.GetAll().Success);
            Console.WriteLine(carManager.GetAll().Message);

            Console.WriteLine("ID :1 -> " + carManager.GetById(1).Data.Description);

            foreach (var c in carManager.GetAllDetailsOfCar().Data) // Join yapılmış tam hali
            {
                Console.WriteLine("ID :" + c.CarId + " " + c.ModelYear + " " + c.ColorName + " " + c.BrandName + " " + c.Description);
            }

            Console.WriteLine("\n*** *** *** *** *** *** ***");
            foreach (var c in carManager.GetCarsByBrandId(6).Data)
            {
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.Description);
            }

            Console.WriteLine("\n** ** ** ** ** ** ** ** **");
            foreach (var c in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.Description);
            }
        }
    }
}
