using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_break语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (true) {
            //    Console.WriteLine(i);
            //    i++;
            //    if (i == 10) {
            //        break;  //跳出最近的循环，一般搭配着if语句一起使用
            //    }
            //}

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("i = "+i);
            //        break;
            //    }
            //}
            while (true) {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                else {
                    Console.WriteLine(num*num);
                }
            }
            Console.WriteLine("循环完成");
            Console.ReadKey();
        }
    }
}
