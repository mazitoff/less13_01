using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using less13_01;

namespace less13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Pen.Size);

            var pen = new Pen("RRRiii");
            //pen.Price = 899;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("йцукен");
            Console.WriteLine(pen.Manufacturer);
            Console.WriteLine(pen.Price);

            Console.ReadKey();
        }
    }
}
