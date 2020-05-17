using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_continue和return使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<10) {
            //    // break;  //跳出最近循环
            //    //continue;       //跳出本次循环,循环体continue下面的语句不执行，一般配合着if一起使用
            //    if (i == 5) {
            //        Console.WriteLine("continue");
            //        i++;
            //        continue;
            //    }
            //    if (i == 10) {
            //        Console.WriteLine("break");
            //        break;
            //    }
            //    Console.WriteLine("欢迎听五斗米的课 " + i);
            //    i++;
            //}

            //int num = 0;
            //do
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        return; //直接返回，循环后面的代码也不执行了，方法的返回
            //    }
            //    else {
            //        Console.WriteLine(num * num);
            //    }
            //} while (true);
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0) {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("循环完成");
            Console.ReadKey();

        }
    }
}
