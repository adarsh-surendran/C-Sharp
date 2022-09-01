using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo10
    {
        public static void Main()
        {
            float a, b, c, d, e;
            Console.WriteLine("Enter three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = (a + b) * c;
            e = a * b + b * c;
            Console.WriteLine("Result of specified numbers " + a + ", " + b + " and " + c + ", (x+y).z is " + d + " and x.y + y.z is " + e);
            Console.ReadKey();
        }
    }
}
