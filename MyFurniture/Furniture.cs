using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Furniture
    {
        const double basePrice = 25000;
        static uint counter = 1;
        protected uint id;
        protected void IdNovel() 
        { 
            id = counter++;
        }

        public virtual double getPrice() { return basePrice; }

        public uint getId() { return id; }

        public virtual string Print()
        {
            return getId() + ". ";
        }
    }
}
