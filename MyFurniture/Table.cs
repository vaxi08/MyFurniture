using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Table: Furniture
    {
        const double tableFactor = 0.3;
        int height;


        public Table(int height)
        {
            IdNovel();
            this.height = height;
        }
        public override double getPrice()
        {
            return base.getPrice() * tableFactor;
        }
        public override string Print()
        {
            return base.Print() + "Az asztal magassága: " + this.height + "cm és az ára: " + getPrice() + "Ft.";
        }
    }
}
