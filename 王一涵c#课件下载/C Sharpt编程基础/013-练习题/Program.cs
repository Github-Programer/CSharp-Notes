using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.输入一个数n，打印0 - n所有的质数  

            //判断是一个数字是否是质数 ,只能被1和他本身整除的数， 2 3 5 7  11
            while (true)
            {
                Console.WriteLine("请输入一个数字:");
                int n = Convert.ToInt32(Console.ReadLine());
                //这一层循环时，遍历0-n里面所有的数字
                for (int j = 0; j < n; j++)
                {

                    bool isOk = true;
                    //这一层循环时，判断j是否是质数
                    for (int i = 2; i < j; i++)
                    {
                        if (j % i == 0)
                        {
                            isOk = false;
                            break;
                        }
                    }
                    if (isOk == true)
                    {
                        Console.WriteLine(j + "是质数");
                    }
                    else
                    {
                        //Console.WriteLine(j + "不是质数====");
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
