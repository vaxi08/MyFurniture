using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] bútor = new Furniture[3];

            bútor[0] = new Table(170);
            bútor[1] = new Bed(220, 170);
            bútor[2] = new Chair(4);

            for (int i = 0; i < bútor.Length; i++)
            {
                Console.WriteLine(bútor[i].Print());
            }
        }
    }
}
