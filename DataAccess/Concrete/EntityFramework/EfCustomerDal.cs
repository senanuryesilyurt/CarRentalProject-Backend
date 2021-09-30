using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectDbContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetAllByCustomerDetailsDto()
        {
            using(ReCapProjectDbContext context=new ReCapProjectDbContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.UserId
                             select new CustomerDetailsDto
                             {
                                 CustomerId=c.CustomerId,
                                 UserId=u.UserId,
                                 FirstName = u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=c.CompanyName
                             };
                return result.ToList();

            }
        }
    }
}
