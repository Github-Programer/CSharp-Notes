using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j = 0;
            //while (j < 10) {
            //    Console.WriteLine("while 欢迎听五斗米的课");
            //    j++;
            //}

            int k = 0;
            for (; k < 10; )
            {
                Console.WriteLine("for 欢迎听五斗米的课");
                k++;
            }
            //执行过程：先执行表达式1，再执行表达式2，循环体，表达式3，表达式2，循环体，表达式3，表达式2，循环……
            for (int i=0; i<10;i++ ) {
                Console.WriteLine("欢迎听五斗米的课");  //0 1 2
            }
            int sum = 0;
            for (int i = 2; i <=100; i+=2)
            {
                //if (i % 2 == 0) {
                    sum += i;
                //}
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
