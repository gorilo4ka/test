using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void test(int x = 7, int y = -2)
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        static void Main(string[] args)
        {
            test();
            Console.WriteLine();

            test(5);
            Console.WriteLine();

            test(10);
            Console.WriteLine();

            test(5, 10);
            Console.WriteLine();

            test(y: 14);
            Console.WriteLine();

            test(y: 7, x: 4);

            Console.ReadKey();
        }
    }
}
