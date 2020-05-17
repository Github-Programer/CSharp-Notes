using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_方法_函数_
{
    class Program
    {
        static void Main(string[] args)
        {
            //超级玛丽   走走走 停停停，跳跳跳   碰到蘑菇  变大   碰到五星   无敌

            // ZouTiao();
            // ChiMoGu();
            // ZouTiao();
            //ChiXing();
            //ZouTiao();
            // ZouTiao();
            // ZouTiao();
            // ZouTiao();
            // ChiXing();
            // ChiXing();
            // ChiXing();

            //实际参数
            //Log("aaa",15);
            //Add(6,3,2);
            //int m = 15;
            //int n = 2;
            //int k = 1;
            //Add(m,n,k);

            //int max = GetMax(n, m);
            //Console.WriteLine(max);

            //string str = Console.ReadLine();
            //Console.WriteLine(str);

            //while (true) {
            //    Console.WriteLine("aaaaaaaaaaaaa");
            //    Console.WriteLine("aaaaaaaaaaaaa");
            //    Console.WriteLine("aaaaaaaaaaaaa");
            //    return;
            //}
            //Console.WriteLine("bbbb");
            //Console.WriteLine("bbbbb");

            //int result = GetMaxItem(new int[]{ 15,30,89,1,-79});
            //Console.WriteLine("result = "+ result);

            //int result1 = GetMaxItem(new int[] { 33, 30, 726, 1, -1836 });
            //Console.WriteLine("result1 = " + result1);

            int result = GetMaxItem1("hello",15, 30, 89, 1, -79);
            Console.WriteLine("result = " + result);

            Console.ReadKey();
        }
        public static int GetMaxItem1(string a,params int[] arg)
        {
            Console.WriteLine(a);
            int rs = int.MinValue;
            foreach (var item in arg)
            {
                if (item > rs)
                    rs = item;
            }
            return rs;
        }
        /// <summary>
        /// 获取一组数中最大值
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static int GetMaxItem(int[] arg) {
            int rs = int.MinValue;
            foreach (var item in arg)
            {
                if (item > rs)
                    rs = item;
            }
            return rs;
        }
        /// <summary>
        /// 获取两个数中较大的哪一个
        /// </summary>
        /// <param name="a">数1</param>
        /// <param name="b">数2</param>
        /// <returns>大数</returns>
        public static int GetMax(int a, int b) {
            if (a > b)
            {
                return a;
            }
            else{
                return b;
            }
        }

        /// <summary>
        /// 打印的方法
        /// </summary>
        /// 形式参数
        public static void Log(string str,int i) {
            Console.WriteLine(str+" : "+i);
        }
        /// <summary>
        /// 求加法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void Add(int a, int b, int c) {
            Console.WriteLine("he = "+(a+b+c));
        }

        /// <summary>
        /// 这个是走跳的方法
        /// </summary>
        public static void ZouTiao() {
            Console.WriteLine("走啊走，跳啊跳");
            Console.WriteLine("走啊走，跳啊跳");
            Console.WriteLine("走啊走，跳啊跳");
            Console.WriteLine("走啊走，跳啊跳");
            Console.WriteLine("播放一段走的声音");
            Console.WriteLine("走啊走，跳啊跳");
        }
        /// <summary>
        /// 这个是吃到了蘑菇
        /// </summary>
        public static void ChiMoGu() {
            Console.WriteLine("我碰到了一个小蘑菇");
            Console.WriteLine("播放一个吃蘑菇的音乐");
            Console.WriteLine("播放的一个屏幕特效");
            Console.WriteLine("吃到了 ，变大");
        }
        /// <summary>
        /// 这个是吃到了星星
        /// </summary>
        public static void ChiXing() {
            Console.WriteLine("碰到了一个小星星，吃到了");
            Console.WriteLine("播放一个星星的音乐");
            Console.WriteLine("一个酷炫的特效");
            Console.WriteLine("加一个无敌的Buff");}
    }
}
