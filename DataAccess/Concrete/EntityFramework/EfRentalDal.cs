using Core;
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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectDbContext>, IRentalDal
    {
        public List<RentalDetailDto> rentalDetailDtos()
        {
           using(ReCapProjectDbContext context=new ReCapProjectDbContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.UserId
                             join r in context.Rentals on c.CustomerId equals r.CustomerId
                             join car in context.Cars on r.CarId equals car.CarId
                             join b in context.Brands on car.BrandId equals b.BrandId
                             join clr in context.Colours on car.ColourId equals clr.ColourId
                             select new RentalDetailDto
                             {
                                 CarId=car.CarId,
                                 BrandName=b.BrandName,
                                 ColourName=clr.ColourName,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=c.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                                 RentalId=r.RentalId
                             };
                return result.ToList();
            }
            
        }
    }
}
