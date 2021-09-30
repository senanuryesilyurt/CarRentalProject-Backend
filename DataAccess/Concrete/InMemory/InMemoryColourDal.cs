using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColourDal : IColourDal
    {
        List<Colour> _colours;
        public InMemoryColourDal()
        {
            _colours = new List<Colour>
            {
                new Colour{ColourId=1,ColourName="Siyah"},
                new Colour{ColourId=2,ColourName="Beyaz"},
                new Colour{ColourId=3,ColourName="Mavi"},
                new Colour{ColourId=4,ColourName="Kırmızı"},
                new Colour{ColourId=5,ColourName="Gold"},
            };
        }
        public void Add(Colour colour)
        {
            Colour VarMı = _colours.Find(x => x.ColourName == colour.ColourName);
            if (VarMı == null) 
            {
                _colours.Add(colour);
                Console.WriteLine("Renk eklendi.");
            }
            else
            {
                Console.WriteLine("Bu renk Mevcut. Başka bir renk eklemeyi deneyin.");
            }
            
        }

        public void Delete(Colour colourId)
        {
            Colour colourToDelete = _colours.SingleOrDefault(c => c.ColourName == colourId.ColourName);
            _colours.Remove(colourToDelete);
            Console.WriteLine("Renk Silindi.");
        }

        public Colour Get(Expression<Func<Colour, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Colour> GetAll(Expression<Func<Colour, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Colour entity)
        {
            throw new NotImplementedException();
        }
    }
}
