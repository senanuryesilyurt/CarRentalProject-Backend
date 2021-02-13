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
        List<Rental> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Rental> 
            { 
                new Rental{BrandId=1, BrandName=" FIAT "},
                new Rental{BrandId=2, BrandName=" MERCEDES "} ,
                new Rental{BrandId=3, BrandName=" AUDI "},
                new Rental{BrandId=4, BrandName=" BMV "},
                new Rental{BrandId=5, BrandName=" CITROEN "},
                new Rental{BrandId=6, BrandName=" FORD "},
                new Rental{BrandId=7, BrandName=" DACIA "},
            };
        }
        public void Add(Rental brand)
        {
            Rental VarMı = _brands.Find(x => x.BrandName == brand.BrandName);
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

        public void Delete(Rental brandId)
        {
            Rental brandToAdd = _brands.SingleOrDefault(b => b.BrandId == brandId.BrandId);
            Console.WriteLine(brandToAdd.BrandName + " markası silindi.");
        }

        public Rental Get(Expression<Func<Rental, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
