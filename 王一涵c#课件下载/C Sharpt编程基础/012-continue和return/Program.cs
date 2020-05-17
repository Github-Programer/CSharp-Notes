using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_continue和return
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (true) {
            //    //break;//跳出最近的循环
            //    //continue;  //跳出本次循环,一般搭配着if一起使用
            //    if (i == 5) {
            //        Console.WriteLine("continue");
            //        i++;
            //        continue;
            //    }
            //    if (i == 10) {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}
            int i = 0;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                else {

                }
            } while (true);
            Console.WriteLine("循环结束");
            Console.ReadKey();
        }
    }
}
