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
            //CarTest();

            //Console.WriteLine("\n");

            //ColorTest();

            //Console.WriteLine("\n");

            //BrandTest();

            //Console.WriteLine("\n");

            //CustomerTest();

            //Console.WriteLine("\n");

            //UserTest();

            //Console.WriteLine("\n");

            //RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //rentalManager.Add(new Rental(1, 1, DateTime.Now.Date, new DateTime(2021, 2, 15)));
            //rentalManager.Add(new Rental(5, 2, DateTime.Now.Date, new DateTime(2021, 3, 15)));
            string messsage = rentalManager.Add(new Rental(3, 4, DateTime.Now.Date, new DateTime(2021, 3, 15))).Message;
            //rentalManager.Add(new Rental(2, 3, DateTime.Now.Date, new DateTime(2021, 3, 15)));
            //rentalManager.Add(new Rental(6, 4, DateTime.Now.Date, new DateTime(2021, 3, 16)));

            Console.WriteLine(messsage);

            foreach (var r in rentalManager.GetAll().Data)
            {
                Console.WriteLine(r.RentalId + " " + r.CarId + " " + r.CustomerId + " " + r.RentDate + " " + r.ReturnDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User("Mustafa", "Zaimoğlu", "mkz@gmail.com", "12345678"));
            //userManager.Add(new User("Mehmet", "Badem", "bdm@gmail.com", "87654321"));
            //userManager.Add(new User("Johnny", "Depp", "depp@gmail.com", "12345678"));
            //userManager.Add(new User("Fernando", "Sucre", "sucre@gmail.com", "87654321"));

            foreach (var u in userManager.GetAll().Data)
            {
                Console.WriteLine(u.UserId + " " + u.FirstName+ " " + u.LastName + " " + u.Email);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //customerManager.Add(new Customer(1, "MKZ Corp"));
            //customerManager.Add(new Customer(2, "Bademler Gaming"));
            //customerManager.Add(new Customer(3, "Netflix"));
            //customerManager.Add(new Customer(4, "Spotify"));

            foreach (var c in customerManager.GetAll().Data)
            {
                Console.WriteLine(c.CustomerId + " " + c.UserId + " " + c.CompanyName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand("Nissan"));
            brandManager.Add(new Brand("Mazda"));
            brandManager.Add(new Brand("Toyota"));
            brandManager.Add(new Brand("Honda"));
            brandManager.Add(new Brand("Mitsubishi"));
            brandManager.Add(new Brand("Renault"));

            foreach (var b in brandManager.GetAll().Data)
            {
                Console.WriteLine(b.BrandId + " " + b.BrandName);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color("Yellow"));
            colorManager.Add(new Color("Green"));
            colorManager.Add(new Color("Bayside Blue"));
            colorManager.Add(new Color("Gray"));
            colorManager.Add(new Color("Obsidian Black"));
            colorManager.Add(new Color("White"));
            colorManager.Add(new Color("Purple"));
            colorManager.Add(new Color("Pink"));
            colorManager.Add(new Color("Red"));

            foreach (var c in colorManager.GetAll().Data)
            {
                Console.WriteLine(c.ColorId + " " + c.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*
            Console.WriteLine(carManager.GetAll().Success);
            Console.WriteLine(carManager.GetAll().Message);

            Console.WriteLine("ID :1 -> " + carManager.GetById(1).Data.Description);

            foreach (var c in carManager.GetAllDetailsOfCar().Data) // Join yapılmış tam hali
            {
                Console.WriteLine("ID :" + c.CarId + " " + c.ModelYear + " " + c.ColorName + " " + c.BrandName + " " + c.Description + " " + c.DailyPrice + " TL");
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
            */
        }
    }
}
