using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;        //声明一个变量  变量的类型是 整数   名字age
            //age = 18;       //把18 赋值给变量age
            //string name = "五斗米";        //声明一个字符串类型的变量，变量名字为name，并且赋值为五斗米
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            //int level = 0;  //先赋值再使用  
            //level = 15;     //变量可以重复被赋值，赋值新的以后 ，之前的值就没有
            //Console.WriteLine(level);
            //string level = "";  //变量不能重复声明，名字一样 就是重复了

            int anim6;
            int _lo_56ve;
            int @woaa_68rld;
            int love = 10;
            int Love = 20;

            int myInt = 32;     //测试驼峰命名法
            int myint = 32;

            int chinese = 90;  
            int math = 85;
            int english = 96;

            Console.WriteLine("我的年龄是{0}",25);
            //格式化字符串，填坑的数量可以比坑多，
            Console.WriteLine("我的语文成绩是{0}，我的数学成绩是{1}，我的英语成绩是{0}", chinese,math,english);
            Console.ReadKey();
        }
    }
}
