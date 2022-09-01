using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo9
    {
        public static void Main9()
        {
            float a, b, c, d, e;
            Console.WriteLine("Enter four Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = (a + b + c + d) / 4;
            Console.WriteLine("The average of " + a + ", " + b + ", " + c + ", " + d + " is " + e);
            Console.ReadKey();
        }
    }
}
