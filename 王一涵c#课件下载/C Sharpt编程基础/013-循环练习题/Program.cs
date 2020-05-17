using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_循环练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.找出100-999所有的水仙花数  个位*个位*个位+十位*十位*十位+百位*百位*百位 = n
            //for (int i = 100; i < 1000; i++)
            //{
            //    int g = i % 10; //个位数
            //    int s = i % 100 / 10;       //十位数字
            //    int b = i / 100;    //百位数字
            //    if (b * b * b + s * s * s + g * g * g == i) {
            //        Console.WriteLine(i+" 是水仙花数");
            //    }
            //}   
            //2.打印九九乘法表
            //int count = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    //j循环时  i循环的循环体
            //    for (int j = 1; j <= i; j++)
            //    {
            //        //count++;
            //        //Console.WriteLine("欢迎听五斗米的课,"+ count);
            //        //Console.WriteLine("i = {0},j = {1}",i,j);
            //        Console.Write("{0}*{1} = {2}   ",j,i,i*j);
            //    }
            //    Console.WriteLine();//换行
            //}

            //3.
            //Console.Write("请输入一个数字：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("{0}+{1}={2}",i,n-i,n);
            //}

            //4.输入一个数n，打印0-n所有的质数  
            //只能被1和他本身整除的数 叫质数，  2 3 5 7 11 
            Console.Write(" 请输入一个数字：");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int j = 2; j < n; j++)
            {
                bool isOk = true;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        //只要被整除了，肯定不是质数，所以直接跳出就好了
                        isOk = false;
                        break;
                    }
                }
                if (isOk)
                {
                    Console.WriteLine("{0}是质数",j);
                }
                else
                {
                    //Console.WriteLine("不是质数");
                }
            }

            

            Console.ReadKey();
        }
    }
}
