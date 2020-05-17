using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a1 = 32;
            int a2 = 10;
            int he = a1 + a2 ;
            int cha = a1 - a2;
            int ji = a1 * a2;
            int shang = a1 / a2;
            int yu = a1 % a2;
            //如果两个整数相除，结果肯定是整数，会自动舍去小数部分
            
            Console.WriteLine("he = {0},cha = {1},ji = {2},shang = {3},yu = {4}",he,cha,ji,shang,yu);
            Console.WriteLine("+连接符测试  he = "+he+",cha = "+cha+",ji = "+ji+",shang = "+shang+",yu = "+yu);
            int n1 = 5;
            int n2 = 2;
            float n3 = 2f;
            double n4 = 2.0;
            Console.WriteLine(n1/ n4);


            string str = "world";
            string str1 = "hello";
            //字符串+字符串 是连接的作用
            //Console.WriteLine(str+str1+"nihao");          //worldhellonihao
            //任何类型跟字符串相加都是等于字符串类型
            Console.WriteLine(5+str);       //5world    
            Console.WriteLine(5+5 + str);       //表达式的计算是从左向右计算的，所以先计算5+5 然后10+world
            Console.WriteLine(str1+5 + 5 + str);        //^


            //赋值运算符
            int myInt = 5;
            myInt += 3;     //等同于 myInt = myInt+3;   //  8
            myInt -= 5;     // myInt = myInt-5;    // 3
            myInt *= 2;     //myInt = myInt*2;      //6
            myInt /= 3;     //myInt = myInt/3;      //2
            myInt = 5;
            myInt %= 2;     //myInt = myInt%2;      //1

            Console.WriteLine("myInt = "+myInt);

            int m = 5;
            //m++;
            //++m;        //++ 如论在变量前还是变量后，都相当于m = m+1;
            //区别 m++ 是先使用值，然后在自己+1
            //++m  先+1，在使用m的值          +号在前面就先加后使用，在后面就先使用后加
            //int m1 = m++;
            int m1 = ++m;
            Console.WriteLine("m = "+m+",m1 = "+m1);


            int k = 5;
            //int k1 = k--;     ////4,5
            int k1 = --k;       ////4,4
            Console.WriteLine("k = " + k + ",k1 = " + k1);

            int km = 8;
            Console.WriteLine("km = "+(++km));      //如果一元运算符和其他运算符在表达式里面挨着，运算符之间要用空格隔开，否则报错

            //声明同类型的多个变量，可以这样写 
            //变量类型  变量名1,变量名2，变量名3； 
            //前提必须是同类型的变量
            int var1, var2 = 5, var3 = 6;
            //var1 = var2++ * --var3;
            //var1 = ++var2 * var3--;
            var1 = var2++ * --var3 + ++var2 * var3--;   //5 * 5 + 7*5
            Console.WriteLine("var1 = "+ var1);
            */

            //运算符的优先级  优先级高的运算符先计算
            //int n1 = 10 + 5;
            //int n2 = 10/3 + 5 * 2;
            //int n3 = 10 % 3 + 5 * 2;        //*/% 的优先级要高于 +-
            //Console.WriteLine("n1 = {0}, n2 = {1},n3 = {2}", n1, n2, n3);

            //int var1, var2 = 5, var3 = 6;
            //var1 = var2++ * --var3 + ++var2 * var3--;   //5 * 5 + 7*5   //一元运算符 优先级是最高的，所以有限计算
            //Console.WriteLine("var1 = " + var1);

            ////int n4 = 3 * 5 + 8 / 2 + 9 % 2;     //15+4+1
            ////int n4 = 3 * (5 + 8) / 2 + 9 % 2;       //3*12/2+1          //括号可以改变运算符的优先级，先算括号里面的，括号可以多层嵌套
            //int n4 = 3 * ((5 + 8) / 2 + 9) % 2;         //3*15%2
            //Console.WriteLine("n4 = "+n4);


            //读取用户输入
            //string str = Console.ReadLine();        //读取用户输入的信息，回车结束，读取的是一行，我们可以直接用来给string变量赋值
            //Console.WriteLine("用户输入了："+str);

            //string num1 = Console.ReadLine();
            //int _num1 = Convert.ToInt32(num1);      //Convert类里面有一些转换的方法，我们可以使用 用来转换  .ToInt32是转为int类型

            string num2 = Console.ReadLine();
            double _num2 = Convert.ToDouble(num2);      //将字符串转换为double类型

            
            Console.WriteLine("用户输入的数字的平方是："+(_num2 * _num2));
            Console.ReadKey();  
        }
    }
}
