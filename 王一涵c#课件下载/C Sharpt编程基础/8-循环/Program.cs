using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<10) {
            //    Console.WriteLine("我围着操场跑了第{0}圈",i); //0 1 2 3 4 5 6 7 8 9 
            //    i++;
            //}
            //Console.WriteLine("循环完成");


            //1.打印15次 ”欢迎听五斗米老师的课”
            //int i = 0;
            //while (i < 15) {
            //    Console.WriteLine("欢迎听五斗米老师的课");
            //    i++;
            //}
            //Console.WriteLine("循环完成");

            //2 . 3   1-100 求和

            //int num = 1;
            //int sum = 0;
            //while (num < 101) {
            //    //Console.WriteLine(num);
            //    if (num % 2 != 0) {
            //        sum += num;
            //    }
            //    num++;
            //}
            //Console.WriteLine("sum = "+sum);

            //4.提示用户输入yes 或者no，只要不是yes或者no，就一直提示用户输入，直到输入yes和no为止。
            //Console.WriteLine("请输入yes 或者no");
            //string input = Console.ReadLine();
            //while (input != "yes" && input != "no") {
            //    Console.WriteLine("你只能输入yes 或者no");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("你输入的是： "+input);
            //5.输入班级人数，然后依次输入学生成绩，计算班级学员的总成绩和平均成绩
            Console.WriteLine("请输入班级的人数");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            int i = 0;
            while (i<num) {
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;
                i++;
            }
            Console.WriteLine("你们班里有{0}个人，总成绩是{1},平均成绩是{2}",num,sum,sum/num);
            
            Console.ReadKey();
        }
    }
}
