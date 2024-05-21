using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Code19
    {
        static void Main()
        {
            int x = 0;
            int y = 0;

            Console.Write("숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("또 다른 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (x > y)
            {
                Console.WriteLine("먼저 입력한 숫자가 더 큽니다");
            }
            else
            {
                Console.WriteLine("나중에 입력한 숫자가 더 큽니다");
            }
        }
    }
}
