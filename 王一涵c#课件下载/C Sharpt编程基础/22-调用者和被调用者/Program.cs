using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_调用者和被调用者
{
    class Program
    {
        static int a = 15;
        static void Main(string[] args)
        {
            
            //调用者
            a = TestOne();
            Console.WriteLine(a);
            Console.ReadKey();
        }
        //被调用者
        public static int TestOne() {
            a = a + 10;
            Console.WriteLine("TestOne : "+ a);
            return a;
        }
        public static void TestTwo()
        {
            a = a + 10;
            Console.WriteLine("TestTwo : " + a);
        }
    }
}
