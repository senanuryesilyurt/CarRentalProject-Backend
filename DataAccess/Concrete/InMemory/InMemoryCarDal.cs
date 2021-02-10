using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars = new List<Car>() 
        { 
            new Car {CarId=1,CarName=" BMW" ,ColourId=1,BrandId=3, DailyPrice=3000, ModelYear=2015, Description="Yakıt: Dizel, Vites: Manuel" },
            new Car {CarId=2,CarName=" BMW", ColourId=5,BrandId=1, DailyPrice=2850, ModelYear=2002, Description="Kasko: Full Kasko" },
            new Car {CarId=3, CarName=" BMW",ColourId=3,BrandId=7, DailyPrice=4100, ModelYear=2018, Description="Sadece haftalık kiralama" },
        };


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car entity)
        {
           
            _cars.Remove(entity);
            Console.WriteLine("Araç silindi.");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            
            Car UpdateToCar = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            if (UpdateToCar != null)
            {
                UpdateToCar.CarId = car.CarId;
                UpdateToCar.CarName=car.CarName;
                UpdateToCar.BrandId = car.BrandId;
                UpdateToCar.ColourId = car.ColourId;
                UpdateToCar.DailyPrice = car.DailyPrice;
                UpdateToCar.Description = car.Description;
                UpdateToCar.ModelYear = car.ModelYear;
            }
           
        }

    }
}
