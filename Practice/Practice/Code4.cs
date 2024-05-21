using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Code4
    {
        static void MainCode4(string[] args)
        {
            int x = 100;
            double y = 3.14;
            char z = 'A';

            Console.WriteLine("{0}, {1}, {2}", x, y, z);
            Console.WriteLine("{0}, {0}, {0}", x, y, z);
            Console.WriteLine("{1}, {1}, {1}", x, y, z);
            Console.WriteLine("{2}, {2}, {2}", x, y, z);
            Console.WriteLine("{2}, {1}, {0}", x, y, z);

        }
    }
}
