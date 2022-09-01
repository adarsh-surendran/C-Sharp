using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo7
    {
        public static void Main7()
        {
            float a, b,c;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);
            c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);
            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);
            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);
            Console.ReadKey();
        }
    }
}
