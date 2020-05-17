using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_变量类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果存储的数字位数，超出了变量的最大存储范围会报错的
            byte myByte = 123;
            int myInt = 23;
            long myLong = 1000030023000;
            Console.WriteLine("myByte = {0},myInt = {1},myLong = {2}",myByte,myInt,myLong);

            double d = 3.14;        //默认的小数都是double类型
            float f = 3.14f;        //float 类型，精度更低， 数字后面跟f 表示float类型
            decimal dc = 0.732589m;         //精度更高一些，一般用来计算钱相关的变量，数字后面加m 表示decimal类型
            Console.WriteLine("double = {0},float = {1},decimal = {2}", d, f, dc);


            char myChar = 'A';      //单引号表示 char  单引号里面只能由一个字符
            char myChar2 = '男';
            string myStr = "hello,world";       //双引号表示字符串
            bool myBool = true;     // true or false
            Console.WriteLine("myChar = {0},myChar2 = {1},myStr = {2},myBool = {3}", myChar, myChar2, myStr,myBool);


            //练习1 
            //去银行办理业务的时候，他会让你填一张表,这张表的里的内容要存到电脑上,有姓名、年龄、邮箱、家庭住址,工资.之后把这些信息显示出来
            string name = "五斗米";
            int age = 23;
            string email = "282726478@qq.com";
            string addr = "北京";
            double salary = 2003.5;
            Console.WriteLine("大家好，我是{0},我今天{1}岁了，我的邮箱是{2}，我现在住在{3}，我的工资只有{4}",name,age,email,addr,salary);

            //练习2
            //定义两个变量如:num1,num2分别赋值为32和18,写程序交换两个变量的值
            int num1 = 32;
            int num2 = 18;

            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("num1 = {0},num2 = {1}",num1,num2);

            // \开头  在字符串里面表示有特殊含义 
            string myStr2 = "\"hello\",\n\tworld\\";
            Console.WriteLine(myStr2);

            //@修饰的字符串，会保存格式,所以可以有换行和缩进
            //字符串原样输出，不识别转义字符
            //两个双引号可以表示一个双引号

            string myStr3 = @"我叫五斗米，
                                    我住在""北京";
            string myStr4 = "我叫五斗米,我住在北京";

            string path1 = "D:\\Program\\File\\Software\\Unity.exe";
            string path2 = @"D:\Program\File\Software\Unity.exe";
            Console.WriteLine(path2);
            Console.WriteLine(myStr3);
            Console.ReadKey();
        }
    }
}
