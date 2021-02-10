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
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapProjectDbContext>,ICarDal
    {
       public List<CarDetailDto> GetCarDetails()
       {
            using (ReCapProjectDbContext context=new ReCapProjectDbContext())
            {

                var result = from c in context.Cars
                             join clr in context.Colours
                             on c.ColourId equals clr.ColourId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName, 
                                 BrandName = b.BrandName,
                                 ColourName = clr.ColourName, 
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
            
       }
    }
}
