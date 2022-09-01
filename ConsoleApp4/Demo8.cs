using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo8
    {
        public static void Main8()
        {
            int a,b;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                b = a * i;
                Console.WriteLine(a + " * " + i + " = " + b);
            }
            Console.ReadKey();
        }
    }
}
