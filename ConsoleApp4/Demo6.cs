using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo6
    {
        public static void Main6()
        {
            int a, b, c,d;
            Console.WriteLine("Enter 3 numbers to multiply");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = a * b * c;
            Console.WriteLine("Answer: "+d);
            Console.ReadKey();

        }
    }
}
