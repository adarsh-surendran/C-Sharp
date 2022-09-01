using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo5
    {
        public static void Main5()
        {
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
}
