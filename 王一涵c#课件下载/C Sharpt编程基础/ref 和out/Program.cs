using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_和out
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 8, 2, 9, 15 };
            //int[]  rs = CtrlArray(arr);
            //Console.WriteLine("最大值 : "+rs[0]);
            //Console.WriteLine("最小值 : " + rs[1]);
            //Console.WriteLine("Sum : " + rs[2]);


            //string str;
            //bool bl;
            //int cc = Test(out str,out bl);
            //Console.WriteLine(str);
            //Console.WriteLine(cc);
            //Console.WriteLine(bl);

            //string msg;
            //bool isSuccess = CheckUser("wdm","admin",out msg);
            //Console.WriteLine(isSuccess);
            //Console.WriteLine(msg);
            //out 可以实现返回多个不同类型的结果，out 参数必须在方法内初始化

            //double salary = 5000;
            //JiangJin(ref salary);
            //Console.WriteLine(salary);

            //交换两个int类型的变量
            int a = 10;
            int b = 20;

            //int temp = a;
            //a = b;
            //b = temp;

            //a = a - b;
            //b = a + b;
            //a = b - a;

            Change(ref a, ref b);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.ReadKey();
        }
        public static void Change(ref int n1, ref int n2) {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        public static void JiangJin(ref double s) {
            s += 500;
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">提示信息</param>
        /// <returns>是否登录成功</returns>
        public static bool CheckUser(string userName, string pwd, out string msg) {
            if (userName == "wdm" && pwd == "admin")
            {
                msg = "登录成功";
                return true;
            }
            else if (userName != "wdm")
            {
                msg = "用户名错误";
                return false;
            }
            else {
                msg = "密码错误";
                return false;
            }
        }
        /// <summary>
        /// 获取数组的最大值 最小值 和
        /// </summary>
        /// <param name="arr">需要操作的数组</param>
        /// <returns>返回的结果</returns>
        public static int[] CtrlArray(int[] arr) {
            
            int[] result = new int[3];
            //result[0]  最大值    result[1]  z最小值   result[2] 和
            result[0] = int.MinValue;
            result[1] = int.MaxValue;
            result[2] = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > result[0]) {
                    result[0] = arr[i];
                }
                if (arr[i] < result[1]) {
                    result[1] = arr[i];
                    }
                result[2] += arr[i];
            }
            return result;
        }
        public static int Test(out string aa,out bool b) {
            aa = "hello";
            int bb = 100;
            b = false;
            return bb;
        }
    }
}
