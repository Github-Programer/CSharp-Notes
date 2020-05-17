//我开始注释了 ，编译器会忽略这部分
// 引入命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A - GameA - 程序员A
// B - GameB - 程序员B
// C - GameC - 程序员A 或者程序员B


//项目的命名空间，尽量不要有中文
//{ }  用大括号括起来
namespace _001我的第一个项目
{
    // 定义了一个类，{} 括起来  class 关键字修饰
    class Program
    {
        //定义一个方法，{}括起来 Main方法，程序的入口
       
        static void Main(string[] args)
        {
            #region 这是我们第一个项目的测试代码
            //方法体
            //Console.WriteLine("Hello,World");       //; ；  () （）  

            //Console.WriteLine("Hello,world2");

            //Console.WriteLine("你好，世界");

            //Console.WriteLine("你好，世界2");

            //Console.WriteLine("Hello,World");

            //Console.WriteLine("Hello,world2");

            //Console.WriteLine("你好，世界");

            //Console.WriteLine("你好，世界2");
            #endregion

            //Console.WriteLine("Hello,World ~");     //把要输出到屏幕的内容放到引号里面
            //Console.Write("Hello");
            //Console.WriteLine("Hello2");
            //Console.ReadKey();      //暂停程序  等待一个键的输入 输入的值会显示在屏幕上
            //Console.WriteLine("Hello,World ~2");
            /**/
            Console.WriteLine("**********************************************");
            Console.WriteLine("*          这是我的第一个C#应用程序          *");
            Console.WriteLine("**********************************************");

            //阿克江的说服力砍价啊两地分居
            Console.WriteLine("Hello,World");//将HelloWorld 输出到屏幕上
            Console.ReadKey();  //暂停程序
            

            
        }
    }
}
