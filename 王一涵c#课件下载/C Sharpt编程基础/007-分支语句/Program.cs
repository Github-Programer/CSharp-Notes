using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_分支语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //if语句
            //bool b = false;
            //if (32>18)
            //{
            //    Console.WriteLine("条件成立");
            //    Console.WriteLine("条件成立2");
            //}

            //练习1
            //Console.WriteLine("请输入你的年龄：");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isOk = age >= 23;
            //if (isOk == true) {
            //    Console.WriteLine("你到结婚年龄了");
            //}
            //Console.WriteLine("这是if之外的语句");
            //练习二
            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (userName == "wdm" && pwd == "111")
            //{
            //    Console.WriteLine("登陆成功");
            //}


            //if-else 语句
            //double total = 100;
            //Console.WriteLine("请输入芝麻信用的评分：");
            //string scoreStr = Console.ReadLine();
            //int score = Convert.ToInt32(scoreStr);
            //if (score > 700)
            //{
            //    total *= 0.8;       //total = total*0.8;
            //}
            //else {
            //    total *= 0.9;
            //}
            //Console.WriteLine("你的总价是："+total);

            //练习题
            //Console.WriteLine("请输入a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a % b == 0 || a + b > 100)
            //{
            //    Console.WriteLine(a);
            //}
            //else {
            //    Console.WriteLine(b);
            //}

            //三元运算符
            //bool result = 5 < 3 ? true : false;
            //Console.WriteLine("result = "+result);

            //练习
            //double total = 100;
            //Console.WriteLine("请输入芝麻信用的评分：");
            //string scoreStr = Console.ReadLine();
            //int score = Convert.ToInt32(scoreStr);
            //total = score > 700 ? total * 0.8 : total * 0.9;
            ////if (score > 700)
            ////{
            ////    total *= 0.8;       //total = total*0.8;
            ////}
            ////else
            ////{
            ////    total *= 0.9;
            ////}
            //Console.WriteLine("你的总价是：" + total);

            //if-elseif-else语句
            //Console.WriteLine("请输入你的成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else {
            //    Console.WriteLine("E");
            //}


            //练习题
            //Console.WriteLine("请输入用户名:");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码:");
            //string pwd = Console.ReadLine();
            //if (userName == "wdm" && pwd == "111")
            //{
            //    Console.WriteLine("输入正确");
            //}
            //else if (userName != "wdm")
            //{
            //    Console.WriteLine("用户名不正确");
            //}
            //else {
            //    Console.WriteLine("密码错误");
            //}

            //switch case语句
            //李四的年终工作评定,
            //如果定为A级,则工资涨500元,
            //如果定为B级,则工资涨200元,
            //如果定为C级,工资不变,
            //如果定为D级工资降200元,
            //如果定为E级工资降500元.   5000
            /*
            int salary = 5000;
            Console.WriteLine("请输入评级：");
            string level = Console.ReadLine();
            bool isOk = true;
            switch (level) {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    isOk = false;
                    Console.WriteLine("评级输入有误,程序退出");
                    break;
            }
            if (isOk) {
                Console.WriteLine("李四的工资是{0}", salary);
            }
            */

            Random random = new Random();       //创建一个随机数的对象
            int res = random.Next(1,7);      //产生一个1-7的随机数，不包含7，但是包含1
            switch (res) {
                case 1:
                    Console.WriteLine("我是程序员");
                    break;
                case 2:
                    Console.WriteLine("我是美术");
                    break;
                case 3:
                    Console.WriteLine("我是策划");
                    break;
                case 4:
                    Console.WriteLine("我是项目经理");
                    break;
                case 5:
                    Console.WriteLine("我是测试");
                    break;
                case 6:
                    Console.WriteLine("我是运营");
                    break;
            }
            Console.ReadKey();
        }
    }
}
