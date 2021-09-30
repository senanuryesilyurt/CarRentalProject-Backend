using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

         
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar = new Car { CarId=3003,CarName= "NAME", BrandId = 4, ColourId = 2, DailyPrice = 800 ,ModelYear=2019,Description="Yeni"};
            // carManager.Add(newCar);

            //foreach (var car in carManager.GetCarsByColorId(1002))
            //{
            //    Console.WriteLine("Arabanın Adı : " + car.CarName + " Açıklaması : " + car.Description + " Üretim yılı : " + car.ModelYear + " Günlük ücreti : " + car.DailyPrice);
            //}


            //carManager.Update(newCar);


            //carManager.Delete(newCar);


            //Console.WriteLine("-------- CAR LIST ---------");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Car Name: {0}\nBrand Name: {1}\nColor Name: {2}\nDaily Price: {3}", car.CarName, car.BrandName, car.ColourName, car.DailyPrice);
            //    Console.WriteLine("--------------------------------");
            //}
        }
    }
}
