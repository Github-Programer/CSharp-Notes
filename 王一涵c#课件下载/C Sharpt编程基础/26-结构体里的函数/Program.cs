using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_结构体里的函数
{
    class Program
    {

        public struct Person {
            public int age;
            public string name;
            public char sex;
            public void SayHello() {
                Console.WriteLine("大家好，我叫{0},我今年{1}岁了，我是一个{2}",name,age,sex == 'N'?"男孩":"女孩");
            }
        }
        static void Main(string[] args)
        {
            Person p;
            p.age = 18;
            p.name = "张三";
            p.sex = 'm';
            p.SayHello();
            //结构体里也是可以有方法的，方法可以有静态和非静态  ，静态的   结构体名.方法名();
            //非静态的方法 对象名.方法名();
            //静态方法里面 用的字段 必须都是静态的
            //Person.SayHello();
            Console.ReadKey();
        }
    }
}
