using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_类型_转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123.4";
            //int i = Convert.ToInt32(str);       //面子上要过得去
            double i = Convert.ToDouble(str);
            Console.WriteLine(i);

            //int a = 15;
            //double b = a;   //隐式转换，我们不需要做什么，编译器会自动帮我们转换，小范围数据放到大范围类型的变量
            //float f = 1.5f;
            //b = f;

            ////f = (float)b;  //显式转换，大范围这种数据放到小范围类型变量里面，我们需要告诉编译器，转换的类型是什么
            ////在转换值得前面 （类型） 有可能数据精度丢失丢失

            //a = (int)f;

            //Console.WriteLine(a);

            int a = 15;
            //转string  任何类型变量，都可以.ToString();
            //string b = a.ToString();
            // string b = Convert.ToString(a);
            string b = a + "";
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
