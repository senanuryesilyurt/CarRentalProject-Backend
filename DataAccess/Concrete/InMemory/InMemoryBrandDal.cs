using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand> 
            { 
                new Brand{BrandId=1, BrandName=" FIAT "},
                new Brand{BrandId=2, BrandName=" MERCEDES "} ,
                new Brand{BrandId=3, BrandName=" AUDI "},
                new Brand{BrandId=4, BrandName=" BMV "},
                new Brand{BrandId=5, BrandName=" CITROEN "},
                new Brand{BrandId=6, BrandName=" FORD "},
                new Brand{BrandId=7, BrandName=" DACIA "},
            };
        }
        public void Add(Brand brand)
        {
            Brand VarMı = _brands.Find(x => x.BrandName == brand.BrandName);
            if (VarMı == null) 
            {
                _brands.Add(brand);
                Console.WriteLine(brand.BrandName + " markası başarıyla eklendi. ");
            }
            else
            {
                Console.WriteLine("Bu marka mevcut. Başka bir marka eklemeyi deneyin.");
            }
        }

        public void Delete(Brand brandId)
        {
            Brand brandToAdd = _brands.SingleOrDefault(b => b.BrandId == brandId.BrandId);
            Console.WriteLine(brandToAdd.BrandName + " markası silindi.");
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
