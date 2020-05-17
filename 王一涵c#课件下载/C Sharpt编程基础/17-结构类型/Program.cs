using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_结构类型
{
    //用struct 关键字  后面跟结构体的名字
    //一次声明多个类型的变量
    struct Person {
        public string name;
        public Gender gender;
        public int age;
        public string addr;
    }
    enum Gender {
        Male,
        Female
    }
    class Program
    {
        static void Main(string[] args)
        {
            //公司管理系统  姓名，性别 年龄
            //声明结构体，并且赋值
            Person p1;
            p1.name = "张三";
            p1.gender = Gender.Male;
            p1.age = 18;
            p1.addr = "北京";

            Person p2;
            p2.name = "李四";
            p2.gender = Gender.Female;
            p2.age = 20;
            p2.addr = "河南";

            //使用结构的值
            Console.WriteLine(p1.name+"的年龄是："+p1.age+",性别是："+p1.gender);
            Console.ReadKey();
        }
    }
}
