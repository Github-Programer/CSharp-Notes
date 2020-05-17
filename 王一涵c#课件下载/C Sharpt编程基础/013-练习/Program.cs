using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.输入一个数n，打印0-n所有的质数  能被1和本身整除的数  2
            while (true) { 
            Console.WriteLine("请输入一个数字:");
            int n = Convert.ToInt32(Console.ReadLine());

            //判断n是否是质数
            if (n < 2)
            {
                Console.WriteLine("输入错误");
            }
            else {
                bool isOk = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0) {
                        isOk = false;
                        break;
                    }
                }
                    if (isOk)
                    {
                        Console.WriteLine("你输入的是质数");
                    }
                    else {
                        Console.WriteLine("不是质数");
                    }
            }
            }
            Console.ReadKey();
        }
    }
}
