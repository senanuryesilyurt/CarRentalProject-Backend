using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDbContext>,ICarDal
    {
        public List<Car> GetByFilter(string brandName, string colorName)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var result = from c in context.Cars
                             join clr in context.Colours
                             on c.ColourId equals clr.ColourId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             where b.BrandName==brandName && clr.ColourName==colorName
                             select new Car
                             {
                                  CarId = c.CarId,
                                  CarName = c.CarName,
                                  BrandId = c.BrandId,
                                  ColourId=c.ColourId,
                                  ModelYear = c.ModelYear,
                                  Description = c.Description,
                                  DailyPrice = c.DailyPrice
                              };

                return result.ToList();
            }

        }

        public List<CarDetailDto> GetCarDetailsById(int carId)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {

                var result = from c in context.Cars
                             join clr in context.Colours
                             on c.ColourId equals clr.ColourId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             where c.CarId ==carId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColourName = clr.ColourName,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
                   
            }

        }
    }
}
