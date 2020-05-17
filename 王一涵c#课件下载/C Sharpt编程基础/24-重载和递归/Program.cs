using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_重载和递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(15, 16.6);
            //Console.WriteLine();
            //方法体内自己调用自己
            //一定要有一个条件可以跳出
            JiangGushi(0);
            Console.ReadKey();
        }
        public static void JiangGushi(int i) {
            i++;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有一个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚说，我给你讲一个故事吧");
            if (i >= 5) {
                return;
            }
            JiangGushi(i);
        }
        public static void Add(int a, int b) {
            Console.WriteLine("Add1");
            int sum = a + b;
        }
        public static double Add(int a, double b) {
            Console.WriteLine("Add2");
            return a + b;
        }
        public static string Add(string s1, string s2, string s3) {
            Console.WriteLine("Add3");
            return s1 + s2 + s3;
        }
        public static void Add(string a, int b) {
            Console.WriteLine("Add4");
            Console.WriteLine(a+b);
        }
    }
}
