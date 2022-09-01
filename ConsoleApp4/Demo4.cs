using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Demo4
    {
        public static void Main4()
        {
           
            float a = -1 + 4 * 6;
            Console.WriteLine("-1+4*6 = "+a);
            float b = (35 + 5) % 7;
            float c = 14 + -4 * 6 / 11;
            float d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("(35 + 5) % 7 = " + b);
            Console.WriteLine("14 + -4 * 6 / 11 = " + c);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + d);
            Console.ReadKey();
        }
    }
}
