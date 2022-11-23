using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Bed: Furniture
    {
        const double bedFactor = 2.4;
        int length, width;

        public Bed(int length, int width)
        {
            IdNovel();
            this.length = length;
            this.width = width;
        }
        public override double getPrice()
        {
            return base.getPrice() * bedFactor;
        }
        public override string Print()
        {
            return base.Print() + "Az ágy hossza: " + this.length + "cm, szélessége: " + this.width + "cm és az ára: " + getPrice() + "Ft.";
        }
    }
}
