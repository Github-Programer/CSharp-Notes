using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " hello, BJD,hello,wdm ";
            Console.WriteLine("字符串的长度 Length ：" + str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+",");
            }
            Console.WriteLine("将字符串中的大写字母转换为小写 ToLower()：" + str.ToLower());
            Console.WriteLine("将字符串中的小写字母转换为大写 ToUpper()：" + str.ToUpper());
            //将字符串转换为char数组，其实可以直接当数组操作
            char[] charArr = str.ToCharArray();
            Console.WriteLine(str);
            Console.WriteLine("去除头尾空格  Trim-" + str.Trim());
            Console.WriteLine("去除头空格  Trim-" + str.TrimStart());
            Console.WriteLine("去除尾空格  Trim-" + str.TrimEnd());
            bool isC = str.Contains("hello1");
            Console.WriteLine("是否包含某个字符串 Contains： "+ isC);
            //查找某一个字符串，如果有就返回这个字符串的索引，如果没有返回-1
            int index = str.IndexOf("o,");
            Console.WriteLine("IndexOf : "+ index);
            //插入操作，参数1：在哪个索引位置插入：参数2：要插入的字符串
            //str = str.Insert(index,",bjdedu.com,");
            //Console.WriteLine(str);
            //从字符串后面开始查找
            int index2 = str.LastIndexOf("o,");
            Console.WriteLine("LastIndexOf : " + index2);
            //删除字符串，参数1：从哪个索引位置开始删除，参数2：删除多少个
            //str = str.Remove(str.IndexOf("BJD"),3);
            //Console.WriteLine(str);
            //替换，参数1：老字符串，参数2：新串
            //str = str.Replace("hello", "bjdedu");
            //Console.WriteLine(str);
            //根据某一个字符  切开字符串，返回的是字符串的数组
            //string[] strArr = str.Split(',');
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine(strArr[i]);
            //}
            //截取字符串，参数1：从哪个位置开始截取，参数2：截取的长度,如果不指定长度，就直接到字符串结束
            //str = str.Substring(str.IndexOf("BJD"));
            str = str.Substring(str.LastIndexOf(",")+1,2);
            Console.WriteLine(str);
            Console.WriteLine("===================");
            //bool b = isHui("abcbad");
            //Console.WriteLine(b);

            //bool b = IsContainsHui("aljdsabcbaflakjsdlfjal");
            //Console.WriteLine(b);

            //string rs = GetMaxLenHui("aljdsabcbflakjsdlffffffffffjal");
            //Console.WriteLine("获取最长回文: "+rs);

            int num = GetStrNumber("abccdefcchgkcc","cc");
            Console.WriteLine(num);
            Console.ReadKey();
        }
        /// <summary>
        /// 是否为回文
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isHui(string str) {
            if (str.Length < 3)
            {
                return false;
            }
            else {
                string str1 = "";
                for (int i = str.Length-1; i >= 0; i--)
                {
                    str1 += str[i];
                }
                return str == str1;
            }
        }
        /// <summary>
        /// 是否包含回文
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsContainsHui(string str) {
            int startIndex = 0;
            int strCount = 3;
            while (true) {
                string child = str.Substring(startIndex, strCount);
                bool b = isHui(child);
                if (b == false)
                {
                    strCount++;
                    if (startIndex + strCount > str.Length) {
                        startIndex++;
                        strCount = 3;
                        if (startIndex > str.Length - strCount) {
                            break;
                        }
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 获取最长回文
        /// </summary>
        /// <param name="str">需要查找的字符串</param>
        /// <returns>最长的回文</returns>
        public static string GetMaxLenHui(string str) {
            string rs = "";
            int startIndex = 0;
            int strCount = 3;
            while (true)
            {
                string child = str.Substring(startIndex, strCount);
                bool b = isHui(child);
                //Console.WriteLine("child : "+child);
                if (b == true)
                {
                    //是回文 并且长度是大于rs
                    if (child.Length > rs.Length) {
                        rs = child;
                    }
                }
                strCount++;
                if (startIndex + strCount > str.Length)
                {
                    startIndex++;
                    strCount = 3;
                    if (startIndex > str.Length - strCount)
                    {
                        //Console.WriteLine("break");
                        break;
                    }
                }
            }
            //Console.WriteLine("End");
            return rs;
        }
        /// <summary>
        /// 获取一个字符串在另一个字符串出现的次数
        /// </summary>
        /// <param name="str">总串</param>
        /// <param name="child">子串</param>
        /// <returns>次数</returns>
        public static int GetStrNumber(string str, string child) {
            int num = 0;
            while (true) {
                int index = str.IndexOf(child);
                if (index == -1)
                {
                    break;
                }
                else {
                    num++;
                    //重新截取新串，开始索引+子串长度
                    str = str.Substring(index+child.Length);
                    //Console.WriteLine("str : "+str);
                }
            }
            return num;
        }
    }
}
