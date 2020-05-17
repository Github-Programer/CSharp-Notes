using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_方法练习题
{

    public enum Level {
        优,
        良,
        中,
        差
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArr = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string rs = GetMaxLenStr(strArr);
            //Console.WriteLine(rs);

            //写一个方法，用来判断数字是不是质数
            //bool b = IsPrime(11);
            //Console.WriteLine(b);

            //Level l = CheckLevel(95);
            //Console.WriteLine(l.ToString());


            //请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
            //string[] strArr = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //ReverseArray(strArr);
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine(strArr[i]);
            //}
            //float a, z;
            //GetCircle(5,out a,out z);
            //Console.WriteLine(a +" : "+z);


            //int r = GetMaxNumber(65,687,32,64,51,6854,31,85,31,546,4687);
            //Console.WriteLine(r);


            // 7.请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            int[] arr = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            MaoPao(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public static void MaoPao(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        //获取一组数据最大数
        public static int GetMaxNumber(params int[] arr) {
            int rs = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > rs)
                    rs = arr[i];
            }
            return rs;
        }
        public static void GetCircle(float r, out float area, out float zhou) {
            area = 3.14f * r * r;
            zhou = 3.14f * 2 * r;
        }

        //数组是引用类型，方法里面改变以后，外面也会随着改变
        public static void ReverseArray(string[] arr) {
            for (int i = 0; i < arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
        /// <summary>
        /// 获取成绩 等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static Level CheckLevel(int score) {
            if (score >= 90)
            {
                return Level.优;
            }
            else if (score >= 70)
            {
                return Level.良;
            }
            else if (score >= 60)
            {
                return Level.中;
            }
            else {
                return Level.差;
            }
        }
        /// <summary>
        /// 判断一个数字是否是质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPrime(int num) {
            if (num <= 1)
            {
                return false;
            }
            else {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// 获取一组字符串中最长的那一个
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string GetMaxLenStr(string[] arr) {
            string rs = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > rs.Length) {
                    rs = arr[i];
                }
            }
            return rs;
        }
    }
}
