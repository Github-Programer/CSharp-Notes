using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_结构体的方法
{
    class Program
    {
        public struct Person {
            public  string name;
            public int age;
            public void SayHi() {
                Console.WriteLine("大家好，我叫{0},我今年{1}岁了",name,age);
            }
        }
        static void Main(string[] args)
        {
            Person p;
            p.name = "张三";
            p.age = 18;
            p.SayHi();
           
            Console.ReadKey();
        }
    }
}
