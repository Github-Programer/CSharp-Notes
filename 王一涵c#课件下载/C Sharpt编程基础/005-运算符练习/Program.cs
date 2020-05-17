using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：让用户输入三个数，打印出三个数的积。
            //Console.WriteLine("请输入三个数字");
            //string str1 = Console.ReadLine();           //读取一行的输入数据
            //double num1 = Convert.ToDouble(str1);   //将读取的数据 转换为double类型
            //string str2 = Console.ReadLine();           //读取一行的输入数据
            //double num2 = Convert.ToDouble(str2);   //将读取的数据 转换为double类型
            //string str3 = Console.ReadLine();           //读取一行的输入数据
            //double num3 = Convert.ToDouble(str3);   //将读取的数据 转换为double类型
            //Console.WriteLine("你输入的三个数字的积是 {0}*{1}*{2} = {3}", num1, num2, num3, num1 * num2 * num3);


            // 练习2：计算半径为3的圆的面积和周长并打印出来.（pi为3.14）

            //float pi = 3.14f;
            //float r = 3f;
            //Console.WriteLine("半径为三的圆的面积是{0},周长是{1}",pi*r*r,2*pi*r);


            //练习3:  某游戏商店里面，绿宝石的价格为120个游戏币，血瓶的价格为35个游戏币，问买3个血瓶和2个绿宝石花费多少游戏币，情人节打8.8折以后呢？

            //int sum = 35 * 3 + 120 * 2;
            //Console.WriteLine("3个血瓶和2个绿宝石花费{0}游戏币,打8.8折以后是{1}", sum, sum * 0.88);


            //练习4,编程实现计算几天(如55天)是几周零几 天.
            //string str = Console.ReadLine();
            //int day = Convert.ToInt32(str);
            //Console.WriteLine("{0}天 是{1}周{2}天", day, day / 7, day % 7);

            //练习5: 编程实现用户输入多少秒，然后程序转化为几天几小时几分钟几秒?
            Console.WriteLine("请输入总秒数：");
            int zong = Convert.ToInt32(Console.ReadLine());
            int tian = zong / (3600 * 24);
            int shi = zong % (3600 * 24) / 3600;
            int fen = zong % 3600 / 60;
            int miao = zong % 60;
            Console.WriteLine("你输入的是 {0} 秒，转换后为 {1} 天，{2} 小时 {3} 分钟 {4} 秒",zong,tian,shi,fen,miao);

            Console.ReadKey();
        }
    }
}
