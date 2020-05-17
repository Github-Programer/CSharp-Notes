using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_bool类型
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1 = 15;
            int num2 = 10;
            //bool b = 30 > 25;   //true
            //Console.WriteLine(b);
            bool b1 = num1 > num2;      //true
            bool b2 = num1 < num2;      //false
            bool b3 = num1 >= num2;      //true
            bool b4 = num1 <= num2;      //false
            bool b5 = num1 == num2;      //false
            bool b6 = num1 != num2;      //true
            Console.WriteLine("{0},{1},{2},{3},{4},{5}",b1,b2,b3,b4,b5,b6);


            bool b7 = true;
            bool b8 = !b7;      //！逻辑非，取相反的意思
            Console.WriteLine("b7 = {0},b8 = {1}",b7,b8);

            bool b9 = true;
            bool b10 = false;
            bool b11 = b9 && b10;       //两个&符号表示逻辑与  ，并且   两个表达式都为true  则为true   //false
            bool b12 = b9 || b10;       //逻辑或，或者   有一个为true就为true    //true
            Console.WriteLine("b11 = {0},b12 = {1}", b11, b12);

            //& |  ^
            bool b13 = b9 ^ b10;    //异或   一个为true 一个为false 才为true  //true

            Console.WriteLine("b13 = {0}", b13);
            */

            //练习1：让用户输入老苏的语文和数学成绩,输出以下判断是否正确,正确输出True,错误输出False
            //1)老苏的语文和数学成绩都大于90分
            //2)语文和数学有一门是大于90分的
            //Console.WriteLine("请输入语文成绩： ");
            //int chinese = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("请输入数学成绩： ");
            //int math = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("老苏的语文和数学成绩都大于90分 : "+(chinese >90 && math >90));
            //Console.WriteLine("语文和数学有一门是大于90分 : " + (chinese > 90 || math > 90));

            //练习2：写下判断闰年的表达式,设待判断的年份变量为year.
            //润年的判定(符合下面两个条件之一):
            //年份能够被400整除.(2000)
            //年份能够被4整除但不能被100整除.(2008)
            //让用户输入一个年份,如果是润年,则输出true,如果不是,则输出false.
            Console.WriteLine("请输入一个年份： ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool tiao1 = year % 400 == 0;
            bool tiao2 = year % 4 == 0 && year % 100 != 0;
            bool result = tiao1 || tiao2;
            Console.WriteLine("你输入的年份是{0},它是闰年么？{1}",year,result);
            Console.ReadKey();
        }
    }
}
