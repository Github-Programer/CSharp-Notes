using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_常量
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            a = 18;

            const int b = 25;
           //b = 30;
            Console.WriteLine(a);
            Console.WriteLine(b);
            const float rate = 0.8f;
            const float PI = 3.14f;

            Console.ReadKey();
        }
    }
}
