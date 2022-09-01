using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo2
    {
        public static void Main2()
        {
             int Sum(int e ,int d)
            {
                return e + d;

            }
            Console.WriteLine("Enter 2 numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = Sum(a, b);
            Console.WriteLine("Sum: " + c);
            Console.ReadKey();
        }
    }
}
