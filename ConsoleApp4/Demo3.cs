using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo3
    { public static void Main3()
        {
            Console.WriteLine("Enter 2 numbers");

            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            float Divide(float d,float e)
            {
                return d / e;

            }
            float c = Divide(a, b);
            Console.WriteLine("Quotient: " + c);
            Console.ReadKey();
        }
    }
}
