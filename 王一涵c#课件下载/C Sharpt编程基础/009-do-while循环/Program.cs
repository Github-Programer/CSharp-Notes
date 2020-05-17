using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("欢迎听五斗米的课");
                i++;
            } while (i<10);
            //先执行循环体，在判断条件，至少执行一次
            //while 先判断，在执行循环体，至少执行0次
            Console.WriteLine("循环完成");

            //4.提示用户输入yes 或者no，只要不是yes或者no，就一直提示用户输入，直到输入yes和no为止。
            string input;
            do {
                Console.WriteLine("你只能输入yes 或者no");
                input = Console.ReadLine();
            } while (input != "yes" && input != "no");
           
           
            Console.ReadKey();
        }
    }
}
